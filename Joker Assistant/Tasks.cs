using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace JAssistant
{
	public partial class Tasks : Form
	{
		private List<ActionItem> actionList;

		public Tasks()
		{
			InitializeComponent();
			try
			{
				// Load the actions from the JSON file using the JsonManipulation class
				actionList = JsonManipulation.LoadJsonItems<ActionItem>("tasks.json");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading actions: \n\n{ex.Message}");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			PopulateActionList();
		}

		private void PopulateActionList()
		{
			loadedActionsList.Items.Clear();
			foreach (ActionItem action in actionList)
			{
				loadedActionsList.Items.Add(action.Name);
			}
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (VoiceRecognition.isListening)
					VoiceRecognition.StopRecognizing();

				this.Close();
				Application.Exit();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error exiting application: \n\n{ex.Message}");
			}
		}

		private void toggleSettingsVisibility(object sender, EventArgs e)
		{
			if (this.Visible)
				this.Hide();
			else
				this.Show();
		}

		private void TrayIconContextMenu_Opening(object sender, CancelEventArgs e)
		{
			showSettingsToolStripMenuItem.Text = Visible ? "Hide Tasks Menu" : "Show Tasks Menu";
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void refreshListButton_Click(object sender, EventArgs e)
		{
			loadedActionsList.Items.Clear();
			actionList = JsonManipulation.LoadJsonItems<ActionItem>("tasks.json");
			PopulateActionList();
			reloadGrammar();
		}

		private void loadedActionsList_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (loadedActionsList.SelectedIndex >= 0)
			{
				ActionItem selectedAction = actionList[loadedActionsList.SelectedIndex];
				nameTextBox.Text = selectedAction.Name;
				typeDropbox.SelectedIndex = selectedAction.Type;
				keywordsTextBox.Text = selectedAction.Keywords;
				actionTextBox.Text = selectedAction.Action;
				parametersTextBox.Text = selectedAction.Parameters;
				runAsAdminCheckbox.Checked = selectedAction.Admin;
				exactMatchCheckbox.Checked = selectedAction.ExactMatch;
			}
		}

		private void editCurrentItemButton_Click(object sender, EventArgs e)
		{
			if (loadedActionsList.SelectedIndex < 0) {
				MessageBox.Show("No item selected.");
				return;
			}

			// Ask the user to confirm the edit
			DialogResult result = MessageBox.Show("Are you sure you want to edit this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) {
				return;
			}

			// Get the selected item index from the loadedActionsList
			int selectedIndex = loadedActionsList.SelectedIndex;

			// Get the selected action item from the actionList
			ActionItem selectedAction = actionList[selectedIndex];

			// Update the properties of the selected action item with the new values from the textboxes
			selectedAction.Name = nameTextBox.Text;
			selectedAction.Type = typeDropbox.SelectedIndex;
			selectedAction.Keywords = keywordsTextBox.Text;
			selectedAction.Action = actionTextBox.Text;
			selectedAction.Parameters = parametersTextBox.Text;
			selectedAction.Admin = runAsAdminCheckbox.Checked;
			selectedAction.ExactMatch = exactMatchCheckbox.Checked;

			// Save the updated actionList to the tasks.json file
			JsonManipulation.SaveActions(actionList, "tasks.json");

			// Refresh the loadedActionsList to show the updated items
			loadedActionsList.Items.Clear();
			actionList = JsonManipulation.LoadJsonItems<ActionItem>("tasks.json");
			PopulateActionList();

			// Select the previously selected item again
			loadedActionsList.SelectedIndex = selectedIndex;

			reloadGrammar();
		}

		private void deleteCurrentItemButton_Click(object sender, EventArgs e)
		{
			if (loadedActionsList.SelectedIndex <= 0)
			{
				return;
			}

			int selectedIndex = loadedActionsList.SelectedIndex;

			DialogResult result = MessageBox.Show("Are you sure you want to delete selected item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No)
			{
				return;
			}

			actionList.RemoveAt(selectedIndex);

			// Save the updated actionList to the tasks.json file
			try
			{
				JsonManipulation.SaveActions(actionList, "tasks.json");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error saving actions to file:  \n\n{ex.Message}");
			}

			actionList = JsonManipulation.LoadJsonItems<ActionItem>("tasks.json");
			PopulateActionList();
			ClearFields();
			reloadGrammar();
		}

		private void typeDropbox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (typeDropbox.SelectedIndex == 0)
			{
				label5.Text = "Executable path";
				parametersTextBox.Enabled = true;
				runAsAdminCheckbox.Enabled = true;
			}

			if (typeDropbox.SelectedIndex == 1)
			{
				label5.Text = "Website url";
				parametersTextBox.Enabled = false;
				runAsAdminCheckbox.Enabled = false;
			}
		}

		private void addNewItemButton_Click(object sender, EventArgs e)
		{
			ClearFields();

			// Create a new ActionItem object with the example values
			ActionItem newItem = new ActionItem
			{
				Name = "Example",
				Type = 0,
				Keywords = "Open my program",
				Action = @"C:\Users\me\Desktop\myProgram.exe",
				Parameters = "+fullscreen"
			};

			try
			{
				// Add the new item to the config file using JsonManipulation.cs
				JsonManipulation.AddItem(newItem);

				// Reload the actionList and repopulate the loadedActionsList
				actionList = JsonManipulation.LoadJsonItems<ActionItem>("tasks.json");
				PopulateActionList();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error adding new item:  \n\n{ex.Message}");
			}

			reloadGrammar();
		}

		private void ClearFields()
		{
			nameTextBox.Clear();
			typeDropbox.SelectedIndex = -1;
			keywordsTextBox.Clear();
			actionTextBox.Clear();
			parametersTextBox.Clear();
			runAsAdminCheckbox.Checked = false;
			exactMatchCheckbox.Checked = false;
		}

		private void reloadConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			reloadGrammar();
		}

		private void reloadGrammar()
		{
			try
			{
				VoiceRecognition.ReloadGrammar();
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while reloading configuration: \n\n" + ex.Message);
			}
		}

		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			Preferences pref = new Preferences();
			pref.ShowDialog();
		}

		private void stopListeningToolStripMenuItem_Click(object sender, EventArgs e)
		{
			VoiceRecognition.ToggleRecognition();
			if (VoiceRecognition.isListening)
			{
				toggleListeningToolStripMenuItem.Text = "Pause Recognition";
			}
			else
			{
				toggleListeningToolStripMenuItem.Text = "Resume Recognition";
			}
		}

		private void showSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Preferences pref = new Preferences();

			if (this.Visible)
			{
				pref.StartPosition = FormStartPosition.CenterParent;

			}
			else
			{
				pref.StartPosition = FormStartPosition.CenterScreen;
			}

			pref.Show();
		}
	}

}
