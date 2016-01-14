using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FF13FullLauncher
{
    public partial class SettingsForm : Form
    {
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string TipText = string.Format("This option is only importanten for windowed or{0}fullscreen using GeDoSaTo, if the modify config{0}checkbox is enabled.", Environment.NewLine);
            HintToolTip.SetToolTip(label2, TipText);
            HintToolTip.SetToolTip(ResWidth, TipText);
            HintToolTip.SetToolTip(ResXLabel, TipText);
            HintToolTip.SetToolTip(ResHeight, TipText);
            TipText = "This option is only for the cracked game version.";
            HintToolTip.SetToolTip(SubtLangLabel, TipText);
            HintToolTip.SetToolTip(SubtLang, TipText);

            try
            {
                if (!string.IsNullOrWhiteSpace(SilDev.Initialization.ReadValue("Settings", "DispMode")))
                {
                    switch (SilDev.Initialization.ReadValue("Settings", "DispMode").ToLower())
                    {
                        case "fullscreen":
                            DispMode.SelectedIndex = 0;
                            break;
                        case "windowed":
                            DispMode.SelectedIndex = 1;
                            break;
                        case "windowed (borderless)":
                            DispMode.SelectedIndex = 2;
                            break;
                    }
                }

                int width = Screen.PrimaryScreen.Bounds.Width;
                int.TryParse(SilDev.Initialization.ReadValue("Settings", "ResWidth"), out width);
                ResWidth.Value = width;

                int height = Screen.PrimaryScreen.Bounds.Height;
                int.TryParse(SilDev.Initialization.ReadValue("Settings", "ResHeight"), out height);
                ResHeight.Value = height;

                if (!string.IsNullOrWhiteSpace(SilDev.Initialization.ReadValue("Settings", "VoiceLang")))
                {
                    if (SilDev.Initialization.ReadValue("Settings", "VoiceLang") == "Japanese")
                        VoiceLang.SelectedIndex = 0;
                    else
                        VoiceLang.SelectedIndex = 1;
                }

                shadowMap.SelectedItem = SilDev.Initialization.ReadValue("Settings", "ShadowMap");
                if (shadowMap.SelectedIndex < 0)
                    shadowMap.SelectedIndex = 1;

                antiAliasing.SelectedItem = SilDev.Initialization.ReadValue("Settings", "MSAA");
                if (antiAliasing.SelectedIndex < 0)
                    antiAliasing.SelectedIndex = 1;

                if (!string.IsNullOrWhiteSpace(SilDev.Initialization.ReadValue("Settings", "SubtLang")))
                {
                    switch (SilDev.Initialization.ReadValue("Settings", "SubtLang").ToLower())
                    {
                        case "english":
                            SubtLang.SelectedIndex = 0;
                            break;
                        case "french":
                            SubtLang.SelectedIndex = 1;
                            break;
                        case "german":
                            SubtLang.SelectedIndex = 2;
                            break;
                        case "italian":
                            SubtLang.SelectedIndex = 3;
                            break;
                        case "spanish":
                            SubtLang.SelectedIndex = 4;
                            break;
                    }
                }
                else
                    SubtLang.Enabled = false;
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex.Message, "SettingsForm_Load");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (DispMode.SelectedIndex)
                {
                    case 0:
                        SilDev.Initialization.WriteValue("Settings", "DispMode", "Fullscreen");
                        break;
                    case 1:
                        SilDev.Initialization.WriteValue("Settings", "DispMode", "Windowed");
                        break;
                    case 2:
                        SilDev.Initialization.WriteValue("Settings", "DispMode", "Windowed (Borderless)");
                        break;
                }

                SilDev.Initialization.WriteValue("Settings", "ResWidth", ResWidth.Value.ToString());
                SilDev.Initialization.WriteValue("Settings", "ResHeight", ResHeight.Value.ToString());

                SilDev.Initialization.WriteValue("Settings", "ShadowMap", shadowMap.SelectedItem.ToString());
                SilDev.Initialization.WriteValue("Settings", "MSAA", antiAliasing.SelectedItem.ToString());

                if (VoiceLang.SelectedIndex == 0)
                    SilDev.Initialization.WriteValue("Settings", "VoiceLang", "Japanese");
                else
                    SilDev.Initialization.WriteValue("Settings", "VoiceLang", "English");

                SilDev.Initialization.WriteValue("Settings", "SubtLang", SubtLang.SelectedItem.ToString());
                foreach (string file in Directory.GetFiles(Application.StartupPath, "*.ini", SearchOption.AllDirectories))
                    if (file != SilDev.Initialization.File())
                        SilDev.Initialization.WriteValue("Settings", "Language", SubtLang.SelectedItem.ToString().ToLower(), file);
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex.Message, "saveBtn_Click");
            }
            this.Close();
        }

        #region CUSTOM LAYOUT

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void saveBtn_MouseEnter(object sender, EventArgs e)
        {
            saveBtn.BackgroundImage = (Image)Properties.Resources.btn_small_mo_13;
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackgroundImage = (Image)Properties.Resources.btn_small;
        }

        private void cancelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_MouseEnter(object sender, EventArgs e)
        {
            cancelBtn.BackgroundImage = (Image)Properties.Resources.btn_small_mo_13;
        }

        private void cancelBtn_MouseLeave(object sender, EventArgs e)
        {
            cancelBtn.BackgroundImage = (Image)Properties.Resources.btn_small;
        }

        #endregion
    }
}
