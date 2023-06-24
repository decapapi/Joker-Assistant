using System;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Reflection;
using IWshRuntimeLibrary;
using System.Threading;

namespace JAssistant
{
	public partial class Preferences : Form
	{
		public List<UserPreferences> userPreferences;

		public Preferences()
		{
			InitializeComponent();
		}

		private void Preferences_Load(object sender, EventArgs e)
		{
			InitializateUserPreferences();
		}

		public void InitializateUserPreferences()
		{
			if (userPreferences == null)
				userPreferences = JsonManipulation.LoadJsonItems<UserPreferences>("settings.json");

			try
			{
				launchAtStartupCheckbox.Checked = userPreferences[0].LaunchAtStartup;
				startListeningAtLaunchCheckbox.Checked = userPreferences[0].StartListeningAtStartup;
				maxSimultaneousMatches.Value = userPreferences[0].MaxSimultaneousMatches;
				comboBoxGender.SelectedIndex = userPreferences[0].VoiceGender;
				comboBoxCulture.SelectedIndex = userPreferences[0].VoiceCountryCode;
				inputSensitivitySlider.Value = userPreferences[0].InputSensitivity;
				speechVolumeSlider.Value = userPreferences[0].SpeechVolume;
			}
			catch (Exception ex)
			{
				// Handle any exceptions that occur while initializating the settings
				MessageBox.Show("An error occurred while initializating the settings:  \n\n" + ex.Message);
			}

			ApplyUserPreferences();
		}

		public void ApplyUserPreferences()
		{
			try
			{
				try
				{
					if (userPreferences[0].LaunchAtStartup)
					{
						string shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "Joker Assistant.lnk");
						string targetPath = System.Reflection.Assembly.GetEntryAssembly().Location;

						// Create a WshShell object
						var wshShell = new WshShell();

						// Check if shortcut already exists and delete it
						if (System.IO.File.Exists(shortcutPath))
						{
							System.IO.File.Delete(shortcutPath);
						}

						// Create the shortcut
						IWshShortcut shortcut = (IWshShortcut)wshShell.CreateShortcut(shortcutPath);

						// Set shortcut properties
						shortcut.TargetPath = targetPath;
						shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath);
						shortcut.Description = "Shortcut for Joker Assistant";
						shortcut.Save();
					}
					else
					{
						string shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "Joker Assistant.lnk");

						if (System.IO.File.Exists(shortcutPath))
						{
							System.IO.File.Delete(shortcutPath);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occurred while modifying start menu entry:  \n\n" + ex.Message);

				}

				if (!userPreferences[0].StartListeningAtStartup)
				{
					Tasks tasks = new Tasks();
					tasks.TrayIconContextMenu.Text = "Resume Recognition";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while applying user preferences:  \n\n" + ex.Message);
			}
		}

		public void SavePreferences()
		{
			try
			{
				userPreferences[0].LaunchAtStartup = launchAtStartupCheckbox.Checked;
				userPreferences[0].StartListeningAtStartup = startListeningAtLaunchCheckbox.Checked;
				userPreferences[0].InputSensitivity = inputSensitivitySlider.Value;
				userPreferences[0].MaxSimultaneousMatches = (int)maxSimultaneousMatches.Value;
				userPreferences[0].VoiceGender = comboBoxGender.SelectedIndex;
				userPreferences[0].VoiceCountryCode = comboBoxCulture.SelectedIndex;
				userPreferences[0].SpeechVolume = speechVolumeSlider.Value;

				JsonManipulation.SaveActions(userPreferences, "settings.json");

			}
			catch (Exception ex)
			{
				// Handle any exceptions that occur while saving the settings
				MessageBox.Show("An error occurred while saving the settings:  \n\n" + ex.Message);
			}
		}

		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
			SavePreferences();
			this.Close();
		}

		private void Preferences_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void editCurrentItemButton_Click_1(object sender, EventArgs e)
		{
			VoiceRecognition.synthesizer.SpeakAsync("This is a speech synthesis preferences test.");
		}

		private void UpdateSynthesizerSettings(object sender, EventArgs e)
		{
			if (!VoiceRecognition.isListening)
				return;

			try
			{
				string selectedCultureName = comboBoxCulture.SelectedItem.ToString().Split(':')[0];
				CultureInfo selectedCulture = CultureInfo.GetCultureInfo(selectedCultureName);

				VoiceGender selectedGender = (VoiceGender)Enum.Parse(typeof(VoiceGender), comboBoxGender.SelectedItem.ToString(), true);

				VoiceRecognition.synthesizer.SelectVoiceByHints(selectedGender, VoiceAge.Adult, 0, selectedCulture);
				VoiceRecognition.synthesizer.Volume = speechVolumeSlider.Value;
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while updating speech recognition settings #1:  \n\n" + ex.Message);
			}
		}

		private void inputSensitivitySlider_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (!VoiceRecognition.isListening) {
					return;
				}

				VoiceRecognition.sEngine.RecognizeAsyncStop();
				VoiceRecognition.sEngine.UpdateRecognizerSetting("AudioLevel", inputSensitivitySlider.Value);
				VoiceRecognition.sEngine.RecognizeAsync(RecognizeMode.Multiple);
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while updating speech recognition settings #2:  \n\n" + ex.Message);
			}
		}

		private void launchAtStartupCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			ApplyUserPreferences();
		}
	}
}
