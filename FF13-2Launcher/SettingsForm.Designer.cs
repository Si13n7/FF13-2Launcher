namespace FF13FullLauncher
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SubtLang = new System.Windows.Forms.ComboBox();
            this.SubtLangLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VoiceLang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.antiAliasing = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shadowMap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResXLabel = new System.Windows.Forms.Label();
            this.ResHeight = new System.Windows.Forms.NumericUpDown();
            this.ResWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DispMode = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.FormPanelBorder = new System.Windows.Forms.Label();
            this.HintToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WarnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FormPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.FormPanel.BackgroundImage = global::FF13FullLauncher.Properties.Resources.diagonal_pattern;
            this.FormPanel.Controls.Add(this.groupBox2);
            this.FormPanel.Controls.Add(this.groupBox1);
            this.FormPanel.Controls.Add(this.pictureBox1);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(646, 350);
            this.FormPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.SubtLang);
            this.groupBox2.Controls.Add(this.SubtLangLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.VoiceLang);
            this.groupBox2.ForeColor = System.Drawing.Color.Snow;
            this.groupBox2.Location = new System.Drawing.Point(347, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Language Settings";
            // 
            // SubtLang
            // 
            this.SubtLang.AutoCompleteCustomSource.AddRange(new string[] {
            "Japanese",
            "English"});
            this.SubtLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubtLang.FormattingEnabled = true;
            this.SubtLang.Items.AddRange(new object[] {
            "English",
            "French",
            "German",
            "Italian",
            "Spanish"});
            this.SubtLang.Location = new System.Drawing.Point(122, 51);
            this.SubtLang.Name = "SubtLang";
            this.SubtLang.Size = new System.Drawing.Size(125, 21);
            this.SubtLang.TabIndex = 10;
            // 
            // SubtLangLabel
            // 
            this.SubtLangLabel.AutoSize = true;
            this.SubtLangLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtLangLabel.Location = new System.Drawing.Point(24, 55);
            this.SubtLangLabel.Name = "SubtLangLabel";
            this.SubtLangLabel.Size = new System.Drawing.Size(66, 14);
            this.SubtLangLabel.TabIndex = 8;
            this.SubtLangLabel.Text = "Subtitles:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sound:";
            // 
            // VoiceLang
            // 
            this.VoiceLang.AutoCompleteCustomSource.AddRange(new string[] {
            "Japanese",
            "English"});
            this.VoiceLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoiceLang.FormattingEnabled = true;
            this.VoiceLang.Items.AddRange(new object[] {
            "Japanese",
            "English"});
            this.VoiceLang.Location = new System.Drawing.Point(122, 24);
            this.VoiceLang.Name = "VoiceLang";
            this.VoiceLang.Size = new System.Drawing.Size(125, 21);
            this.VoiceLang.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.antiAliasing);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.shadowMap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ResXLabel);
            this.groupBox1.Controls.Add(this.ResHeight);
            this.groupBox1.Controls.Add(this.ResWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DispMode);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(347, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graphic Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Anti-Alaising:";
            // 
            // antiAliasing
            // 
            this.antiAliasing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.antiAliasing.FormattingEnabled = true;
            this.antiAliasing.Items.AddRange(new object[] {
            "2 (MSAA)",
            "4 (MSAA)",
            "8 (MSAA)",
            "16 (MSAA)"});
            this.antiAliasing.Location = new System.Drawing.Point(122, 105);
            this.antiAliasing.Name = "antiAliasing";
            this.antiAliasing.Size = new System.Drawing.Size(123, 21);
            this.antiAliasing.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shadow-Map:";
            // 
            // shadowMap
            // 
            this.shadowMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shadowMap.FormattingEnabled = true;
            this.shadowMap.Items.AddRange(new object[] {
            "512x512",
            "1024x1024",
            "2048x2048",
            "4096x4096",
            "8192x8192"});
            this.shadowMap.Location = new System.Drawing.Point(122, 78);
            this.shadowMap.Name = "shadowMap";
            this.shadowMap.Size = new System.Drawing.Size(123, 21);
            this.shadowMap.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resolution:";
            // 
            // ResXLabel
            // 
            this.ResXLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.ResXLabel.Location = new System.Drawing.Point(173, 53);
            this.ResXLabel.Name = "ResXLabel";
            this.ResXLabel.Size = new System.Drawing.Size(21, 16);
            this.ResXLabel.TabIndex = 4;
            this.ResXLabel.Text = "x";
            this.ResXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResHeight
            // 
            this.ResHeight.Location = new System.Drawing.Point(196, 51);
            this.ResHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ResHeight.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.ResHeight.Name = "ResHeight";
            this.ResHeight.Size = new System.Drawing.Size(49, 21);
            this.ResHeight.TabIndex = 3;
            this.ResHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResHeight.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // ResWidth
            // 
            this.ResWidth.Location = new System.Drawing.Point(122, 51);
            this.ResWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ResWidth.Minimum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.ResWidth.Name = "ResWidth";
            this.ResWidth.Size = new System.Drawing.Size(49, 21);
            this.ResWidth.TabIndex = 2;
            this.ResWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResWidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display Mode:";
            // 
            // DispMode
            // 
            this.DispMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DispMode.FormattingEnabled = true;
            this.DispMode.Items.AddRange(new object[] {
            "Fullscreen",
            "Windowed",
            "Windowed (Borderless)"});
            this.DispMode.Location = new System.Drawing.Point(122, 24);
            this.DispMode.Name = "DispMode";
            this.DispMode.Size = new System.Drawing.Size(123, 21);
            this.DispMode.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FF13FullLauncher.Properties.Resources.cfg_13;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveBtn.BackgroundImage = global::FF13FullLauncher.Properties.Resources.btn_small;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveBtn.Location = new System.Drawing.Point(26, 371);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(274, 50);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseEnter += new System.EventHandler(this.saveBtn_MouseEnter);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelBtn.BackgroundImage = global::FF13FullLauncher.Properties.Resources.btn_small;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.cancelBtn.Location = new System.Drawing.Point(347, 371);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(274, 50);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseClick);
            this.cancelBtn.MouseEnter += new System.EventHandler(this.cancelBtn_MouseEnter);
            this.cancelBtn.MouseLeave += new System.EventHandler(this.cancelBtn_MouseLeave);
            // 
            // FormPanelBorder
            // 
            this.FormPanelBorder.BackColor = System.Drawing.Color.Black;
            this.FormPanelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormPanelBorder.Location = new System.Drawing.Point(0, 350);
            this.FormPanelBorder.Name = "FormPanelBorder";
            this.FormPanelBorder.Size = new System.Drawing.Size(646, 3);
            this.FormPanelBorder.TabIndex = 3;
            // 
            // HintToolTip
            // 
            this.HintToolTip.AutomaticDelay = 200;
            this.HintToolTip.AutoPopDelay = 20000;
            this.HintToolTip.InitialDelay = 200;
            this.HintToolTip.ReshowDelay = 40;
            this.HintToolTip.ShowAlways = true;
            this.HintToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HintToolTip.ToolTipTitle = "Hint:";
            // 
            // WarnToolTip
            // 
            this.WarnToolTip.AutomaticDelay = 200;
            this.WarnToolTip.AutoPopDelay = 20000;
            this.WarnToolTip.InitialDelay = 200;
            this.WarnToolTip.ReshowDelay = 40;
            this.WarnToolTip.ShowAlways = true;
            this.WarnToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.WarnToolTip.ToolTipTitle = "Hint:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::FF13FullLauncher.Properties.Resources.diagonal_pattern;
            this.ClientSize = new System.Drawing.Size(646, 442);
            this.Controls.Add(this.FormPanelBorder);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.FormPanel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Final Fantasy XIII Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.FormPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label FormPanelBorder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox DispMode;
        private System.Windows.Forms.Label ResXLabel;
        private System.Windows.Forms.NumericUpDown ResHeight;
        private System.Windows.Forms.NumericUpDown ResWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VoiceLang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SubtLangLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip HintToolTip;
        private System.Windows.Forms.ComboBox SubtLang;
        private System.Windows.Forms.ToolTip WarnToolTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox antiAliasing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox shadowMap;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}