using JAssistant.Properties;
using System.Drawing;

namespace JAssistant
{
	partial class Tasks
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.TrayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toggleListeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reloadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneElipse2 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.loadedActionsList = new System.Windows.Forms.ListBox();
			this.siticoneElipse3 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
			this.refreshListButton = new Siticone.UI.WinForms.SiticoneButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.exactMatchCheckbox = new Siticone.UI.WinForms.SiticoneWinToggleSwith();
			this.label3 = new System.Windows.Forms.Label();
			this.runAsAdminCheckbox = new Siticone.UI.WinForms.SiticoneWinToggleSwith();
			this.label1 = new System.Windows.Forms.Label();
			this.typeDropbox = new Siticone.UI.WinForms.SiticoneComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.parametersTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.actionTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.keywordsTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nameTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
			this.siticoneVSeparator1 = new Siticone.UI.WinForms.SiticoneVSeparator();
			this.siticoneElipse4 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
			this.editCurrentItemButton = new Siticone.UI.WinForms.SiticoneButton();
			this.deleteCurrentItemButton = new Siticone.UI.WinForms.SiticoneButton();
			this.addNewItemButton = new Siticone.UI.WinForms.SiticoneButton();
			this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
			this.TrayIconContextMenu.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// TrayIcon
			// 
			this.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.TrayIcon.BalloonTipText = "Joker Assistant has been loaded and is running in background";
			this.TrayIcon.BalloonTipTitle = "Joker Assistant";
			this.TrayIcon.ContextMenuStrip = this.TrayIconContextMenu;
			this.TrayIcon.Icon = global::JAssistant.Properties.Resources.jokericon;
			this.TrayIcon.Text = "Joker Assistant is running";
			this.TrayIcon.Visible = true;
			// 
			// TrayIconContextMenu
			// 
			this.TrayIconContextMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSettingsToolStripMenuItem,
            this.showSettingsToolStripMenuItem1,
            this.toggleListeningToolStripMenuItem,
            this.reloadConfigurationToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.TrayIconContextMenu.Name = "TrayIconContextMenu";
			this.TrayIconContextMenu.Size = new System.Drawing.Size(187, 114);
			this.TrayIconContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.TrayIconContextMenu_Opening);
			// 
			// showSettingsToolStripMenuItem
			// 
			this.showSettingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.showSettingsToolStripMenuItem.Name = "showSettingsToolStripMenuItem";
			this.showSettingsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.showSettingsToolStripMenuItem.Text = "Show Tasks Menu";
			this.showSettingsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.showSettingsToolStripMenuItem.Click += new System.EventHandler(this.toggleSettingsVisibility);
			// 
			// showSettingsToolStripMenuItem1
			// 
			this.showSettingsToolStripMenuItem1.Name = "showSettingsToolStripMenuItem1";
			this.showSettingsToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
			this.showSettingsToolStripMenuItem1.Text = "Show App Settings";
			this.showSettingsToolStripMenuItem1.Click += new System.EventHandler(this.showSettingsToolStripMenuItem1_Click);
			// 
			// toggleListeningToolStripMenuItem
			// 
			this.toggleListeningToolStripMenuItem.Name = "toggleListeningToolStripMenuItem";
			this.toggleListeningToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.toggleListeningToolStripMenuItem.Text = "Pause Recognition";
			this.toggleListeningToolStripMenuItem.Click += new System.EventHandler(this.stopListeningToolStripMenuItem_Click);
			// 
			// reloadConfigurationToolStripMenuItem
			// 
			this.reloadConfigurationToolStripMenuItem.Name = "reloadConfigurationToolStripMenuItem";
			this.reloadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.reloadConfigurationToolStripMenuItem.Text = "Reload Configuration";
			this.reloadConfigurationToolStripMenuItem.Click += new System.EventHandler(this.reloadConfigurationToolStripMenuItem_Click);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// siticoneControlBox1
			// 
			this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneControlBox1.ControlBoxStyle = Siticone.UI.WinForms.Enums.ControlBoxStyle.Custom;
			this.siticoneControlBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.siticoneControlBox1.CustomIconSize = 15F;
			this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.Silver;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new System.Drawing.Point(1072, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new System.Drawing.Size(20, 20);
			this.siticoneControlBox1.TabIndex = 41;
			this.siticoneControlBox1.TabStop = false;
			this.siticoneControlBox1.UseTransparentBackground = true;
			// 
			// siticoneElipse1
			// 
			this.siticoneElipse1.BorderRadius = 10;
			this.siticoneElipse1.TargetControl = this;
			// 
			// siticoneElipse2
			// 
			this.siticoneElipse2.BorderRadius = 5;
			this.siticoneElipse2.TargetControl = this.TrayIconContextMenu;
			// 
			// siticoneDragControl1
			// 
			this.siticoneDragControl1.TargetControl = this.panel1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.BlueViolet;
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1100, 30);
			this.panel1.TabIndex = 42;
			// 
			// loadedActionsList
			// 
			this.loadedActionsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.loadedActionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.loadedActionsList.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
			this.loadedActionsList.ForeColor = System.Drawing.Color.White;
			this.loadedActionsList.FormattingEnabled = true;
			this.loadedActionsList.ItemHeight = 20;
			this.loadedActionsList.Location = new System.Drawing.Point(39, 104);
			this.loadedActionsList.Margin = new System.Windows.Forms.Padding(30, 30, 30, 0);
			this.loadedActionsList.Name = "loadedActionsList";
			this.loadedActionsList.Size = new System.Drawing.Size(300, 440);
			this.loadedActionsList.TabIndex = 43;
			this.loadedActionsList.SelectedIndexChanged += new System.EventHandler(this.loadedActionsList_SelectedIndexChanged_1);
			// 
			// siticoneElipse3
			// 
			this.siticoneElipse3.BorderRadius = 10;
			this.siticoneElipse3.TargetControl = this.loadedActionsList;
			// 
			// siticoneLabel1
			// 
			this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
			this.siticoneLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold);
			this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
			this.siticoneLabel1.Location = new System.Drawing.Point(39, 66);
			this.siticoneLabel1.Name = "siticoneLabel1";
			this.siticoneLabel1.Size = new System.Drawing.Size(160, 30);
			this.siticoneLabel1.TabIndex = 44;
			this.siticoneLabel1.Text = "Loaded elements";
			// 
			// refreshListButton
			// 
			this.refreshListButton.Animated = false;
			this.refreshListButton.BorderColor = System.Drawing.Color.BlueViolet;
			this.refreshListButton.BorderRadius = 5;
			this.refreshListButton.CheckedState.Parent = this.refreshListButton;
			this.refreshListButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.refreshListButton.CustomImages.Parent = this.refreshListButton;
			this.refreshListButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
			this.refreshListButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.refreshListButton.ForeColor = System.Drawing.Color.White;
			this.refreshListButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.refreshListButton.HoveredState.Parent = this.refreshListButton;
			this.refreshListButton.Location = new System.Drawing.Point(39, 576);
			this.refreshListButton.Margin = new System.Windows.Forms.Padding(30, 30, 15, 30);
			this.refreshListButton.Name = "refreshListButton";
			this.refreshListButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.refreshListButton.ShadowDecoration.Parent = this.refreshListButton;
			this.refreshListButton.Size = new System.Drawing.Size(135, 35);
			this.refreshListButton.TabIndex = 45;
			this.refreshListButton.TabStop = false;
			this.refreshListButton.Text = "Refresh list";
			this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel2.Controls.Add(this.exactMatchCheckbox);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.runAsAdminCheckbox);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.typeDropbox);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.parametersTextBox);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.actionTextBox);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.keywordsTextBox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.nameTextBox);
			this.panel2.Location = new System.Drawing.Point(469, 104);
			this.panel2.Margin = new System.Windows.Forms.Padding(30);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(592, 440);
			this.panel2.TabIndex = 56;
			// 
			// exactMatchCheckbox
			// 
			this.exactMatchCheckbox.CheckedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.exactMatchCheckbox.Location = new System.Drawing.Point(319, 378);
			this.exactMatchCheckbox.Name = "exactMatchCheckbox";
			this.exactMatchCheckbox.Size = new System.Drawing.Size(50, 27);
			this.exactMatchCheckbox.TabIndex = 64;
			this.exactMatchCheckbox.TabStop = false;
			this.exactMatchCheckbox.Text = "siticoneWinToggleSwith1";
			this.exactMatchCheckbox.UncheckedBorderColor = System.Drawing.Color.Gray;
			this.exactMatchCheckbox.UncheckInnerColor = System.Drawing.Color.Gray;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(375, 382);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 19);
			this.label3.TabIndex = 63;
			this.label3.Text = "Exact match";
			// 
			// runAsAdminCheckbox
			// 
			this.runAsAdminCheckbox.CheckedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.runAsAdminCheckbox.Location = new System.Drawing.Point(40, 378);
			this.runAsAdminCheckbox.Name = "runAsAdminCheckbox";
			this.runAsAdminCheckbox.Size = new System.Drawing.Size(50, 27);
			this.runAsAdminCheckbox.TabIndex = 62;
			this.runAsAdminCheckbox.TabStop = false;
			this.runAsAdminCheckbox.Text = "siticoneWinToggleSwith1";
			this.runAsAdminCheckbox.UncheckedBorderColor = System.Drawing.Color.Gray;
			this.runAsAdminCheckbox.UncheckInnerColor = System.Drawing.Color.Gray;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(315, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 19);
			this.label1.TabIndex = 61;
			this.label1.Text = "Action Type";
			// 
			// typeDropbox
			// 
			this.typeDropbox.BackColor = System.Drawing.Color.Transparent;
			this.typeDropbox.BorderRadius = 5;
			this.typeDropbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.typeDropbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typeDropbox.FocusedColor = System.Drawing.Color.White;
			this.typeDropbox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.typeDropbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.typeDropbox.FormattingEnabled = true;
			this.typeDropbox.HoveredState.BorderColor = System.Drawing.Color.BlueViolet;
			this.typeDropbox.HoveredState.Parent = this.typeDropbox;
			this.typeDropbox.IntegralHeight = false;
			this.typeDropbox.ItemHeight = 30;
			this.typeDropbox.Items.AddRange(new object[] {
            "Execute Program",
            "Open Website"});
			this.typeDropbox.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.typeDropbox.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.typeDropbox.ItemsAppearance.Parent = this.typeDropbox;
			this.typeDropbox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 9F);
			this.typeDropbox.Location = new System.Drawing.Point(319, 46);
			this.typeDropbox.Name = "typeDropbox";
			this.typeDropbox.ShadowDecoration.Parent = this.typeDropbox;
			this.typeDropbox.Size = new System.Drawing.Size(248, 36);
			this.typeDropbox.TabIndex = 60;
			this.typeDropbox.SelectedIndexChanged += new System.EventHandler(this.typeDropbox_SelectedIndexChanged_1);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(96, 382);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 19);
			this.label7.TabIndex = 16;
			this.label7.Text = "Run as admin";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(35, 281);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 19);
			this.label6.TabIndex = 14;
			this.label6.Text = "Parameters";
			// 
			// parametersTextBox
			// 
			this.parametersTextBox.BorderRadius = 5;
			this.parametersTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.parametersTextBox.DefaultText = "";
			this.parametersTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.parametersTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.parametersTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.parametersTextBox.DisabledState.Parent = this.parametersTextBox;
			this.parametersTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.parametersTextBox.FocusedState.BorderColor = System.Drawing.Color.BlueViolet;
			this.parametersTextBox.FocusedState.Parent = this.parametersTextBox;
			this.parametersTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.parametersTextBox.HoveredState.BorderColor = System.Drawing.Color.BlueViolet;
			this.parametersTextBox.HoveredState.Parent = this.parametersTextBox;
			this.parametersTextBox.Location = new System.Drawing.Point(39, 308);
			this.parametersTextBox.Margin = new System.Windows.Forms.Padding(130);
			this.parametersTextBox.Name = "parametersTextBox";
			this.parametersTextBox.PasswordChar = '\0';
			this.parametersTextBox.PlaceholderText = "";
			this.parametersTextBox.SelectedText = "";
			this.parametersTextBox.ShadowDecoration.Parent = this.parametersTextBox;
			this.parametersTextBox.Size = new System.Drawing.Size(528, 36);
			this.parametersTextBox.TabIndex = 13;
			this.parametersTextBox.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(35, 190);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 19);
			this.label5.TabIndex = 12;
			this.label5.Text = "Action";
			// 
			// actionTextBox
			// 
			this.actionTextBox.BorderRadius = 5;
			this.actionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.actionTextBox.DefaultText = "";
			this.actionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.actionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.actionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.actionTextBox.DisabledState.Parent = this.actionTextBox;
			this.actionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.actionTextBox.FocusedState.BorderColor = System.Drawing.Color.BlueViolet;
			this.actionTextBox.FocusedState.Parent = this.actionTextBox;
			this.actionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.actionTextBox.HoveredState.BorderColor = System.Drawing.Color.BlueViolet;
			this.actionTextBox.HoveredState.Parent = this.actionTextBox;
			this.actionTextBox.Location = new System.Drawing.Point(39, 216);
			this.actionTextBox.Margin = new System.Windows.Forms.Padding(130);
			this.actionTextBox.Name = "actionTextBox";
			this.actionTextBox.PasswordChar = '\0';
			this.actionTextBox.PlaceholderText = "";
			this.actionTextBox.SelectedText = "";
			this.actionTextBox.ShadowDecoration.Parent = this.actionTextBox;
			this.actionTextBox.Size = new System.Drawing.Size(528, 36);
			this.actionTextBox.TabIndex = 11;
			this.actionTextBox.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(35, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 19);
			this.label4.TabIndex = 10;
			this.label4.Text = "Keywords";
			// 
			// keywordsTextBox
			// 
			this.keywordsTextBox.BorderRadius = 5;
			this.keywordsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.keywordsTextBox.DefaultText = "";
			this.keywordsTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.keywordsTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.keywordsTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.keywordsTextBox.DisabledState.Parent = this.keywordsTextBox;
			this.keywordsTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.keywordsTextBox.FocusedState.BorderColor = System.Drawing.Color.BlueViolet;
			this.keywordsTextBox.FocusedState.Parent = this.keywordsTextBox;
			this.keywordsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.keywordsTextBox.HoveredState.BorderColor = System.Drawing.Color.BlueViolet;
			this.keywordsTextBox.HoveredState.Parent = this.keywordsTextBox;
			this.keywordsTextBox.Location = new System.Drawing.Point(39, 130);
			this.keywordsTextBox.Margin = new System.Windows.Forms.Padding(130);
			this.keywordsTextBox.Name = "keywordsTextBox";
			this.keywordsTextBox.PasswordChar = '\0';
			this.keywordsTextBox.PlaceholderText = "";
			this.keywordsTextBox.SelectedText = "";
			this.keywordsTextBox.ShadowDecoration.Parent = this.keywordsTextBox;
			this.keywordsTextBox.Size = new System.Drawing.Size(528, 36);
			this.keywordsTextBox.TabIndex = 9;
			this.keywordsTextBox.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(35, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Name";
			// 
			// nameTextBox
			// 
			this.nameTextBox.BorderRadius = 5;
			this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nameTextBox.DefaultText = "";
			this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.nameTextBox.DisabledState.Parent = this.nameTextBox;
			this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.BlueViolet;
			this.nameTextBox.FocusedState.Parent = this.nameTextBox;
			this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.nameTextBox.HoveredState.BorderColor = System.Drawing.Color.BlueViolet;
			this.nameTextBox.HoveredState.Parent = this.nameTextBox;
			this.nameTextBox.Location = new System.Drawing.Point(39, 46);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(130);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.PasswordChar = '\0';
			this.nameTextBox.PlaceholderText = "";
			this.nameTextBox.SelectedText = "";
			this.nameTextBox.ShadowDecoration.Parent = this.nameTextBox;
			this.nameTextBox.Size = new System.Drawing.Size(248, 36);
			this.nameTextBox.TabIndex = 5;
			this.nameTextBox.TabStop = false;
			// 
			// siticoneVSeparator1
			// 
			this.siticoneVSeparator1.Location = new System.Drawing.Point(399, 150);
			this.siticoneVSeparator1.Margin = new System.Windows.Forms.Padding(30, 150, 30, 150);
			this.siticoneVSeparator1.Name = "siticoneVSeparator1";
			this.siticoneVSeparator1.Size = new System.Drawing.Size(10, 341);
			this.siticoneVSeparator1.TabIndex = 57;
			// 
			// siticoneElipse4
			// 
			this.siticoneElipse4.BorderRadius = 10;
			this.siticoneElipse4.TargetControl = this.panel2;
			// 
			// editCurrentItemButton
			// 
			this.editCurrentItemButton.Animated = false;
			this.editCurrentItemButton.BorderColor = System.Drawing.Color.BlueViolet;
			this.editCurrentItemButton.BorderRadius = 5;
			this.editCurrentItemButton.CheckedState.Parent = this.editCurrentItemButton;
			this.editCurrentItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.editCurrentItemButton.CustomImages.Parent = this.editCurrentItemButton;
			this.editCurrentItemButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
			this.editCurrentItemButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.editCurrentItemButton.ForeColor = System.Drawing.Color.White;
			this.editCurrentItemButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.editCurrentItemButton.HoveredState.Parent = this.editCurrentItemButton;
			this.editCurrentItemButton.Location = new System.Drawing.Point(469, 576);
			this.editCurrentItemButton.Margin = new System.Windows.Forms.Padding(15, 30, 30, 30);
			this.editCurrentItemButton.Name = "editCurrentItemButton";
			this.editCurrentItemButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.editCurrentItemButton.ShadowDecoration.Parent = this.editCurrentItemButton;
			this.editCurrentItemButton.Size = new System.Drawing.Size(273, 35);
			this.editCurrentItemButton.TabIndex = 58;
			this.editCurrentItemButton.TabStop = false;
			this.editCurrentItemButton.Text = "Edit item";
			this.editCurrentItemButton.Click += new System.EventHandler(this.editCurrentItemButton_Click);
			// 
			// deleteCurrentItemButton
			// 
			this.deleteCurrentItemButton.Animated = false;
			this.deleteCurrentItemButton.BorderColor = System.Drawing.Color.BlueViolet;
			this.deleteCurrentItemButton.BorderRadius = 5;
			this.deleteCurrentItemButton.CheckedState.Parent = this.deleteCurrentItemButton;
			this.deleteCurrentItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteCurrentItemButton.CustomImages.Parent = this.deleteCurrentItemButton;
			this.deleteCurrentItemButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
			this.deleteCurrentItemButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.deleteCurrentItemButton.ForeColor = System.Drawing.Color.White;
			this.deleteCurrentItemButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.deleteCurrentItemButton.HoveredState.Parent = this.deleteCurrentItemButton;
			this.deleteCurrentItemButton.Location = new System.Drawing.Point(788, 576);
			this.deleteCurrentItemButton.Margin = new System.Windows.Forms.Padding(15, 30, 30, 30);
			this.deleteCurrentItemButton.Name = "deleteCurrentItemButton";
			this.deleteCurrentItemButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.deleteCurrentItemButton.ShadowDecoration.Parent = this.deleteCurrentItemButton;
			this.deleteCurrentItemButton.Size = new System.Drawing.Size(273, 35);
			this.deleteCurrentItemButton.TabIndex = 59;
			this.deleteCurrentItemButton.TabStop = false;
			this.deleteCurrentItemButton.Text = "Delete item";
			this.deleteCurrentItemButton.Click += new System.EventHandler(this.deleteCurrentItemButton_Click);
			// 
			// addNewItemButton
			// 
			this.addNewItemButton.Animated = false;
			this.addNewItemButton.BorderColor = System.Drawing.Color.BlueViolet;
			this.addNewItemButton.BorderRadius = 5;
			this.addNewItemButton.CheckedState.Parent = this.addNewItemButton;
			this.addNewItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addNewItemButton.CustomImages.Parent = this.addNewItemButton;
			this.addNewItemButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
			this.addNewItemButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.addNewItemButton.ForeColor = System.Drawing.Color.White;
			this.addNewItemButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.addNewItemButton.HoveredState.Parent = this.addNewItemButton;
			this.addNewItemButton.Location = new System.Drawing.Point(204, 576);
			this.addNewItemButton.Margin = new System.Windows.Forms.Padding(15, 30, 30, 30);
			this.addNewItemButton.Name = "addNewItemButton";
			this.addNewItemButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.addNewItemButton.ShadowDecoration.Parent = this.addNewItemButton;
			this.addNewItemButton.Size = new System.Drawing.Size(135, 35);
			this.addNewItemButton.TabIndex = 46;
			this.addNewItemButton.TabStop = false;
			this.addNewItemButton.Text = "Add action";
			this.addNewItemButton.Click += new System.EventHandler(this.addNewItemButton_Click);
			// 
			// siticoneLabel2
			// 
			this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
			this.siticoneLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold);
			this.siticoneLabel2.ForeColor = System.Drawing.Color.White;
			this.siticoneLabel2.Location = new System.Drawing.Point(469, 66);
			this.siticoneLabel2.Name = "siticoneLabel2";
			this.siticoneLabel2.Size = new System.Drawing.Size(176, 30);
			this.siticoneLabel2.TabIndex = 60;
			this.siticoneLabel2.Text = "Element properties";
			// 
			// siticoneButton1
			// 
			this.siticoneButton1.Animated = false;
			this.siticoneButton1.BackgroundImage = global::JAssistant.Properties.Resources.setting;
			this.siticoneButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.siticoneButton1.BorderColor = System.Drawing.Color.BlueViolet;
			this.siticoneButton1.BorderRadius = 5;
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = System.Drawing.Color.Transparent;
			this.siticoneButton1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.siticoneButton1.ForeColor = System.Drawing.Color.White;
			this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new System.Drawing.Point(1029, 48);
			this.siticoneButton1.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.PressedColor = System.Drawing.Color.Empty;
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new System.Drawing.Size(32, 32);
			this.siticoneButton1.TabIndex = 61;
			this.siticoneButton1.TabStop = false;
			this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
			// 
			// Tasks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.ClientSize = new System.Drawing.Size(1100, 650);
			this.Controls.Add(this.siticoneButton1);
			this.Controls.Add(this.siticoneLabel2);
			this.Controls.Add(this.deleteCurrentItemButton);
			this.Controls.Add(this.editCurrentItemButton);
			this.Controls.Add(this.siticoneVSeparator1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.addNewItemButton);
			this.Controls.Add(this.refreshListButton);
			this.Controls.Add(this.siticoneLabel1);
			this.Controls.Add(this.loadedActionsList);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = global::JAssistant.Properties.Resources.jokericon;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Tasks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Joker Assistant";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.TrayIconContextMenu.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.NotifyIcon TrayIcon;
		private System.Windows.Forms.ToolStripMenuItem showSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
		private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
		private Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;
		private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox loadedActionsList;
		private Siticone.UI.WinForms.SiticoneElipse siticoneElipse3;
		private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
		public Siticone.UI.WinForms.SiticoneButton refreshListButton;
		private Siticone.UI.WinForms.SiticoneVSeparator siticoneVSeparator1;
		private System.Windows.Forms.Panel panel2;
		private Siticone.UI.WinForms.SiticoneElipse siticoneElipse4;
		public Siticone.UI.WinForms.SiticoneButton deleteCurrentItemButton;
		public Siticone.UI.WinForms.SiticoneButton editCurrentItemButton;
		public Siticone.UI.WinForms.SiticoneButton addNewItemButton;
		private System.Windows.Forms.Label label2;
		private Siticone.UI.WinForms.SiticoneTextBox nameTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private Siticone.UI.WinForms.SiticoneTextBox parametersTextBox;
		private System.Windows.Forms.Label label5;
		private Siticone.UI.WinForms.SiticoneTextBox actionTextBox;
		private System.Windows.Forms.Label label4;
		private Siticone.UI.WinForms.SiticoneTextBox keywordsTextBox;
		private System.Windows.Forms.Label label1;
		private Siticone.UI.WinForms.SiticoneComboBox typeDropbox;
		private Siticone.UI.WinForms.SiticoneWinToggleSwith runAsAdminCheckbox;
		private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
		private System.Windows.Forms.ToolStripMenuItem reloadConfigurationToolStripMenuItem;
		private Siticone.UI.WinForms.SiticoneWinToggleSwith exactMatchCheckbox;
		private System.Windows.Forms.Label label3;
		public Siticone.UI.WinForms.SiticoneButton siticoneButton1;
		private System.Windows.Forms.ToolStripMenuItem toggleListeningToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showSettingsToolStripMenuItem1;
		public System.Windows.Forms.ContextMenuStrip TrayIconContextMenu;
	}
}

