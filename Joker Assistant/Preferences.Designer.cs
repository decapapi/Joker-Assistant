using JAssistant.Properties;
using System.Drawing;

namespace JAssistant
{
	partial class Preferences
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
			this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
			this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneShadowForm1 = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.launchAtStartupCheckbox = new Siticone.UI.WinForms.SiticoneWinToggleSwith();
			this.label7 = new System.Windows.Forms.Label();
			this.startListeningAtLaunchCheckbox = new Siticone.UI.WinForms.SiticoneWinToggleSwith();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxGender = new Siticone.UI.WinForms.SiticoneComboBox();
			this.editCurrentItemButton = new Siticone.UI.WinForms.SiticoneButton();
			this.comboBoxCulture = new Siticone.UI.WinForms.SiticoneComboBox();
			this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel4 = new Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel5 = new Siticone.UI.WinForms.SiticoneLabel();
			this.speechVolumeSlider = new Siticone.UI.WinForms.SiticoneTrackBar();
			this.siticoneLabel6 = new Siticone.UI.WinForms.SiticoneLabel();
			this.maxSimultaneousMatches = new Siticone.UI.WinForms.SiticoneNumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.inputSensitivitySlider = new Siticone.UI.WinForms.SiticoneTrackBar();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxSimultaneousMatches)).BeginInit();
			this.SuspendLayout();
			// 
			// siticoneElipse1
			// 
			this.siticoneElipse1.BorderRadius = 10;
			this.siticoneElipse1.TargetControl = this;
			// 
			// siticoneDragControl1
			// 
			this.siticoneDragControl1.TargetControl = this.panel1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.BlueViolet;
			this.panel1.Controls.Add(this.siticoneControlBox2);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(722, 30);
			this.panel1.TabIndex = 42;
			// 
			// siticoneControlBox2
			// 
			this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxStyle = Siticone.UI.WinForms.Enums.ControlBoxStyle.Custom;
			this.siticoneControlBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.siticoneControlBox2.CustomIconSize = 15F;
			this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
			this.siticoneControlBox2.HoveredState.IconColor = System.Drawing.Color.Silver;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new System.Drawing.Point(694, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new System.Drawing.Size(20, 20);
			this.siticoneControlBox2.TabIndex = 43;
			this.siticoneControlBox2.TabStop = false;
			this.siticoneControlBox2.UseTransparentBackground = true;
			this.siticoneControlBox2.Click += new System.EventHandler(this.siticoneControlBox2_Click);
			// 
			// launchAtStartupCheckbox
			// 
			this.launchAtStartupCheckbox.CheckedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.launchAtStartupCheckbox.Location = new System.Drawing.Point(39, 152);
			this.launchAtStartupCheckbox.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
			this.launchAtStartupCheckbox.Name = "launchAtStartupCheckbox";
			this.launchAtStartupCheckbox.Size = new System.Drawing.Size(50, 27);
			this.launchAtStartupCheckbox.TabIndex = 64;
			this.launchAtStartupCheckbox.TabStop = false;
			this.launchAtStartupCheckbox.Text = "siticoneWinToggleSwith1";
			this.launchAtStartupCheckbox.UncheckedBorderColor = System.Drawing.Color.Gray;
			this.launchAtStartupCheckbox.UncheckInnerColor = System.Drawing.Color.Gray;
			this.launchAtStartupCheckbox.CheckedChanged += new System.EventHandler(this.launchAtStartupCheckbox_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(98, 156);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(200, 19);
			this.label7.TabIndex = 63;
			this.label7.Text = "Launch App At System Startup";
			// 
			// startListeningAtLaunchCheckbox
			// 
			this.startListeningAtLaunchCheckbox.Checked = true;
			this.startListeningAtLaunchCheckbox.CheckedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.startListeningAtLaunchCheckbox.Location = new System.Drawing.Point(39, 214);
			this.startListeningAtLaunchCheckbox.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
			this.startListeningAtLaunchCheckbox.Name = "startListeningAtLaunchCheckbox";
			this.startListeningAtLaunchCheckbox.Size = new System.Drawing.Size(50, 27);
			this.startListeningAtLaunchCheckbox.TabIndex = 66;
			this.startListeningAtLaunchCheckbox.TabStop = false;
			this.startListeningAtLaunchCheckbox.Text = "siticoneWinToggleSwith1";
			this.startListeningAtLaunchCheckbox.UncheckedBorderColor = System.Drawing.Color.Gray;
			this.startListeningAtLaunchCheckbox.UncheckInnerColor = System.Drawing.Color.Gray;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(98, 218);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 19);
			this.label1.TabIndex = 65;
			this.label1.Text = "Start Listening on App Launch";
			// 
			// comboBoxGender
			// 
			this.comboBoxGender.BackColor = System.Drawing.Color.Transparent;
			this.comboBoxGender.BorderRadius = 5;
			this.comboBoxGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGender.FocusedColor = System.Drawing.Color.White;
			this.comboBoxGender.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.comboBoxGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.comboBoxGender.FormattingEnabled = true;
			this.comboBoxGender.HoveredState.BorderColor = System.Drawing.Color.BlueViolet;
			this.comboBoxGender.HoveredState.Parent = this.comboBoxGender;
			this.comboBoxGender.IntegralHeight = false;
			this.comboBoxGender.ItemHeight = 30;
			this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
			this.comboBoxGender.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.comboBoxGender.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.comboBoxGender.ItemsAppearance.Parent = this.comboBoxGender;
			this.comboBoxGender.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 9F);
			this.comboBoxGender.Location = new System.Drawing.Point(399, 143);
			this.comboBoxGender.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
			this.comboBoxGender.Name = "comboBoxGender";
			this.comboBoxGender.ShadowDecoration.Parent = this.comboBoxGender;
			this.comboBoxGender.Size = new System.Drawing.Size(282, 36);
			this.comboBoxGender.StartIndex = 0;
			this.comboBoxGender.TabIndex = 67;
			this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.UpdateSynthesizerSettings);
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
			this.editCurrentItemButton.Location = new System.Drawing.Point(399, 336);
			this.editCurrentItemButton.Margin = new System.Windows.Forms.Padding(30, 0, 30, 30);
			this.editCurrentItemButton.Name = "editCurrentItemButton";
			this.editCurrentItemButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.editCurrentItemButton.ShadowDecoration.Parent = this.editCurrentItemButton;
			this.editCurrentItemButton.Size = new System.Drawing.Size(282, 35);
			this.editCurrentItemButton.TabIndex = 69;
			this.editCurrentItemButton.TabStop = false;
			this.editCurrentItemButton.Text = "Test voice";
			this.editCurrentItemButton.Click += new System.EventHandler(this.editCurrentItemButton_Click_1);
			// 
			// comboBoxCulture
			// 
			this.comboBoxCulture.BackColor = System.Drawing.Color.Transparent;
			this.comboBoxCulture.BorderRadius = 5;
			this.comboBoxCulture.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBoxCulture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCulture.FocusedColor = System.Drawing.Color.White;
			this.comboBoxCulture.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.comboBoxCulture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.comboBoxCulture.FormattingEnabled = true;
			this.comboBoxCulture.HoveredState.BorderColor = System.Drawing.Color.BlueViolet;
			this.comboBoxCulture.HoveredState.Parent = this.comboBoxCulture;
			this.comboBoxCulture.IntegralHeight = false;
			this.comboBoxCulture.ItemHeight = 30;
			this.comboBoxCulture.Items.AddRange(new object[] {
            "en-US: United States",
            "en-GB: United Kingdom",
            "en-AU: Australia",
            "en-CA: Canada",
            "en-IN: India",
            "en-IE: Ireland",
            "en-MT: Malta",
            "en-NZ: New Zealand",
            "en-PH: Philippines",
            "en-SG: Singapore",
            "en-ZA: South Africa"});
			this.comboBoxCulture.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.comboBoxCulture.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.comboBoxCulture.ItemsAppearance.Parent = this.comboBoxCulture;
			this.comboBoxCulture.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 9F);
			this.comboBoxCulture.Location = new System.Drawing.Point(399, 214);
			this.comboBoxCulture.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
			this.comboBoxCulture.Name = "comboBoxCulture";
			this.comboBoxCulture.ShadowDecoration.Parent = this.comboBoxCulture;
			this.comboBoxCulture.Size = new System.Drawing.Size(282, 36);
			this.comboBoxCulture.StartIndex = 0;
			this.comboBoxCulture.TabIndex = 70;
			this.comboBoxCulture.SelectedIndexChanged += new System.EventHandler(this.UpdateSynthesizerSettings);
			// 
			// siticoneLabel1
			// 
			this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
			this.siticoneLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Bold);
			this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
			this.siticoneLabel1.Location = new System.Drawing.Point(399, 70);
			this.siticoneLabel1.Name = "siticoneLabel1";
			this.siticoneLabel1.Size = new System.Drawing.Size(132, 25);
			this.siticoneLabel1.TabIndex = 71;
			this.siticoneLabel1.Text = "Speech synthesis";
			// 
			// siticoneLabel2
			// 
			this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
			this.siticoneLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.siticoneLabel2.ForeColor = System.Drawing.Color.White;
			this.siticoneLabel2.Location = new System.Drawing.Point(399, 122);
			this.siticoneLabel2.Name = "siticoneLabel2";
			this.siticoneLabel2.Size = new System.Drawing.Size(82, 19);
			this.siticoneLabel2.TabIndex = 73;
			this.siticoneLabel2.Text = "Voice gender";
			// 
			// siticoneLabel3
			// 
			this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
			this.siticoneLabel3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.siticoneLabel3.ForeColor = System.Drawing.Color.White;
			this.siticoneLabel3.Location = new System.Drawing.Point(399, 193);
			this.siticoneLabel3.Name = "siticoneLabel3";
			this.siticoneLabel3.Size = new System.Drawing.Size(119, 19);
			this.siticoneLabel3.TabIndex = 74;
			this.siticoneLabel3.Text = "Voice country code";
			// 
			// siticoneLabel4
			// 
			this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
			this.siticoneLabel4.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.siticoneLabel4.ForeColor = System.Drawing.Color.White;
			this.siticoneLabel4.Location = new System.Drawing.Point(399, 268);
			this.siticoneLabel4.Name = "siticoneLabel4";
			this.siticoneLabel4.Size = new System.Drawing.Size(49, 19);
			this.siticoneLabel4.TabIndex = 75;
			this.siticoneLabel4.Text = "Volume";
			// 
			// siticoneLabel5
			// 
			this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
			this.siticoneLabel5.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Bold);
			this.siticoneLabel5.ForeColor = System.Drawing.Color.White;
			this.siticoneLabel5.Location = new System.Drawing.Point(39, 70);
			this.siticoneLabel5.Name = "siticoneLabel5";
			this.siticoneLabel5.Size = new System.Drawing.Size(150, 25);
			this.siticoneLabel5.TabIndex = 76;
			this.siticoneLabel5.Text = "Speech recognition";
			// 
			// speechVolumeSlider
			// 
			this.speechVolumeSlider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
			this.speechVolumeSlider.HoveredState.Parent = this.speechVolumeSlider;
			this.speechVolumeSlider.Location = new System.Drawing.Point(399, 293);
			this.speechVolumeSlider.Name = "speechVolumeSlider";
			this.speechVolumeSlider.Size = new System.Drawing.Size(282, 23);
			this.speechVolumeSlider.TabIndex = 78;
			this.speechVolumeSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.speechVolumeSlider.Value = 80;
			this.speechVolumeSlider.ValueChanged += new System.EventHandler(this.UpdateSynthesizerSettings);
			// 
			// siticoneLabel6
			// 
			this.siticoneLabel6.BackColor = System.Drawing.Color.Transparent;
			this.siticoneLabel6.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.siticoneLabel6.ForeColor = System.Drawing.Color.White;
			this.siticoneLabel6.Location = new System.Drawing.Point(39, 268);
			this.siticoneLabel6.Name = "siticoneLabel6";
			this.siticoneLabel6.Size = new System.Drawing.Size(100, 19);
			this.siticoneLabel6.TabIndex = 79;
			this.siticoneLabel6.Text = "Input sensitivity";
			// 
			// maxSimultaneousMatches
			// 
			this.maxSimultaneousMatches.BackColor = System.Drawing.Color.Transparent;
			this.maxSimultaneousMatches.BorderColor = System.Drawing.Color.Transparent;
			this.maxSimultaneousMatches.BorderRadius = 5;
			this.maxSimultaneousMatches.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.maxSimultaneousMatches.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.maxSimultaneousMatches.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.maxSimultaneousMatches.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.maxSimultaneousMatches.DisabledState.Parent = this.maxSimultaneousMatches;
			this.maxSimultaneousMatches.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
			this.maxSimultaneousMatches.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
			this.maxSimultaneousMatches.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
			this.maxSimultaneousMatches.FocusedState.BorderColor = System.Drawing.Color.BlueViolet;
			this.maxSimultaneousMatches.FocusedState.Parent = this.maxSimultaneousMatches;
			this.maxSimultaneousMatches.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxSimultaneousMatches.ForeColor = System.Drawing.Color.White;
			this.maxSimultaneousMatches.Location = new System.Drawing.Point(39, 335);
			this.maxSimultaneousMatches.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.maxSimultaneousMatches.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.maxSimultaneousMatches.Name = "maxSimultaneousMatches";
			this.maxSimultaneousMatches.ShadowDecoration.Parent = this.maxSimultaneousMatches;
			this.maxSimultaneousMatches.Size = new System.Drawing.Size(81, 36);
			this.maxSimultaneousMatches.TabIndex = 81;
			this.maxSimultaneousMatches.TextOffset = new System.Drawing.Point(5, 0);
			this.maxSimultaneousMatches.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.maxSimultaneousMatches.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.maxSimultaneousMatches.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(128, 344);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 19);
			this.label2.TabIndex = 82;
			this.label2.Text = "Max Simultaneous Matches";
			// 
			// inputSensitivitySlider
			// 
			this.inputSensitivitySlider.Enabled = false;
			this.inputSensitivitySlider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
			this.inputSensitivitySlider.HoveredState.Parent = this.inputSensitivitySlider;
			this.inputSensitivitySlider.Location = new System.Drawing.Point(39, 293);
			this.inputSensitivitySlider.Name = "inputSensitivitySlider";
			this.inputSensitivitySlider.Size = new System.Drawing.Size(282, 23);
			this.inputSensitivitySlider.TabIndex = 80;
			this.inputSensitivitySlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.inputSensitivitySlider.Value = 35;
			// 
			// Preferences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.ClientSize = new System.Drawing.Size(720, 410);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.maxSimultaneousMatches);
			this.Controls.Add(this.inputSensitivitySlider);
			this.Controls.Add(this.siticoneLabel6);
			this.Controls.Add(this.speechVolumeSlider);
			this.Controls.Add(this.siticoneLabel4);
			this.Controls.Add(this.siticoneLabel5);
			this.Controls.Add(this.siticoneLabel3);
			this.Controls.Add(this.siticoneLabel2);
			this.Controls.Add(this.siticoneLabel1);
			this.Controls.Add(this.comboBoxCulture);
			this.Controls.Add(this.editCurrentItemButton);
			this.Controls.Add(this.comboBoxGender);
			this.Controls.Add(this.startListeningAtLaunchCheckbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.launchAtStartupCheckbox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = global::JAssistant.Properties.Resources.jokericon;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Preferences";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preferences";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_FormClosing);
			this.Load += new System.EventHandler(this.Preferences_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.maxSimultaneousMatches)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
		private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
		private System.Windows.Forms.Panel panel1;
		private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
		private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
		private Siticone.UI.WinForms.SiticoneWinToggleSwith launchAtStartupCheckbox;
		private System.Windows.Forms.Label label7;
		private Siticone.UI.WinForms.SiticoneWinToggleSwith startListeningAtLaunchCheckbox;
		private System.Windows.Forms.Label label1;
		public Siticone.UI.WinForms.SiticoneButton editCurrentItemButton;
		private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
		private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
		private Siticone.UI.WinForms.SiticoneLabel siticoneLabel4;
		private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
		private Siticone.UI.WinForms.SiticoneLabel siticoneLabel5;
		private Siticone.UI.WinForms.SiticoneTrackBar speechVolumeSlider;
		private Siticone.UI.WinForms.SiticoneLabel siticoneLabel6;
		public Siticone.UI.WinForms.SiticoneComboBox comboBoxCulture;
		public Siticone.UI.WinForms.SiticoneComboBox comboBoxGender;
		private Siticone.UI.WinForms.SiticoneNumericUpDown maxSimultaneousMatches;
		private System.Windows.Forms.Label label2;
		private Siticone.UI.WinForms.SiticoneTrackBar inputSensitivitySlider;
	}
}

