using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace FF13FullLauncher
{
    public partial class MainForm : Form
    {
        Form cfgForm = new SettingsForm();
        string gamePath = Path.Combine(Application.StartupPath, @"alba_data\prog\win\bin\ffxiii2img.exe");

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Length > 1)
                this.Close();
            if (File.Exists(gamePath) || SilDev.Log.DebugEnabled())
            {
                SilDev.Initialization.File(Application.StartupPath, "FFXiii2Launcher.ini");

                if (!SilDev.Elevation.IsAdministrator())
                {
                    bool WriteRights = SilDev.Elevation.WritableLocation();
                    if (!WriteRights)
                        SilDev.Elevation.RestartAsAdministrator();
                }

                if (!File.Exists(SilDev.Initialization.File()))
                    File.Create(SilDev.Initialization.File()).Close();
                
                SilDev.XmlFile.File(Application.StartupPath, "setup.xml");
                if (string.IsNullOrWhiteSpace(SilDev.Initialization.ReadValue("Settings", "DispMode")))
                {
                    string value = SilDev.XmlFile.GetXmlValue("window_mode");
                    SilDev.Initialization.WriteValue("Settings", "DispMode", value == "0" ? "Windowed" : "Fullscreen");
                }
                
                if (string.IsNullOrWhiteSpace(SilDev.Initialization.ReadValue("Settings", "VoiceLang")))
                {
                    string value = SilDev.XmlFile.GetXmlValue("voice_mode");
                    SilDev.Initialization.WriteValue("Settings", "VoiceLang", value == "0" ? "Japanese" : "English");
                }
                
                string SubtLang = string.Empty;
                foreach (string file in Directory.GetFiles(Application.StartupPath, "*.ini", SearchOption.AllDirectories))
                {
                    if (file != SilDev.Initialization.File())
                    {
                        if (!string.IsNullOrWhiteSpace(SilDev.Initialization.ReadValue("Settings", "Language", file)))
                        {
                            if (string.IsNullOrEmpty(SubtLang))
                                SubtLang = SilDev.Initialization.ReadValue("Settings", "Language", file);
                            else
                            {
                                if (SubtLang != SilDev.Initialization.ReadValue("Settings", "Language", file))
                                    SilDev.Initialization.WriteValue("Settings", "Language", SubtLang, file);
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(SilDev.Initialization.ReadValue("Settings", "UserName", file)))
                            ProfileName.Text = SilDev.Initialization.ReadValue("Settings", "UserName", file);
                    }
                }

                if (string.IsNullOrWhiteSpace(ProfileName.Text))
                {
                    string SteamPath = string.Empty;
                    if (SilDev.Reg.SubKeyExist("HKLM", @"SOFTWARE\Valve\Steam"))
                        SteamPath = SilDev.Reg.ReadValue("HKLM", @"SOFTWARE\Valve\Steam", "InstallPath");
                    if (Directory.Exists(SteamPath))
                    {
                        string SteamProfile = Path.Combine(SteamPath, @"config\loginusers.vdf");
                        if (File.Exists(SteamProfile))
                        {
                            foreach (string line in File.ReadLines(SteamProfile))
                            {
                                bool found = false;
                                foreach (string split in line.Split('\"'))
                                {
                                    if (!string.IsNullOrWhiteSpace(split))
                                    {
                                        if (split.ToLower() == "personaname")
                                        {
                                            found = true;
                                            continue;
                                        }
                                        if (found)
                                        {
                                            ProfileName.Text = split;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
                if (string.IsNullOrWhiteSpace(SilDev.Initialization.ReadValue("Settings", "SubtLang")) && !string.IsNullOrWhiteSpace(SubtLang))
                    SilDev.Initialization.WriteValue("Settings", "SubtLang", string.Format("{0}{1}", char.ToUpper(SubtLang[0]), SubtLang.Substring(1)));
            }
            else
            {
                MessageBox.Show(string.Format("Open the root folder of the game to replace the \"FFXiiiLauncher.exe\".{0}{0}Don't forget the backup of the original file!", Environment.NewLine), "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(SilDev.Log.File))
                Process.Start(SilDev.Log.File);
        }

        private void playBtnPan_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name != this.Name)
                {
                    f.Close();
                    break;
                }
            }
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            PlayBw.RunWorkerAsync();
        }

        private void PlayBw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bool IsAdmin = SilDev.Elevation.IsAdministrator();
                if (SilDev.XmlFile.GetXmlValue(SilDev.XmlFile.GetXmlContent(), "window_mode") == "1")
                    SilDev.XmlFile.SetXmlValue("window_mode", "0");

                string dMode = SilDev.Initialization.ReadValue("Settings", "DispMode").ToLower();

                int width = Screen.PrimaryScreen.Bounds.Width;
                int.TryParse(SilDev.Initialization.ReadValue("Settings", "ResWidth"), out width);

                int height = Screen.PrimaryScreen.Bounds.Height;
                int.TryParse(SilDev.Initialization.ReadValue("Settings", "ResHeight"), out height);

                int shadow = 1024;
                switch (SilDev.Initialization.ReadValue("Settings", "ShadowMap"))
                {
                    case "512x512":
                        shadow = 512;
                        break;
                    case "2048x2048":
                        shadow = 2048;
                        break;
                    case "4096x4096":
                        shadow = 4096;
                        break;
                    case "8192x8192":
                        shadow = 4096;
                        break;
                }

                int msaa = 4;
                switch (SilDev.Initialization.ReadValue("Settings", "MSAA"))
                {
                    case "2 (MSAA)":
                        msaa = 2;
                        break;
                    case "8 (MSAA)":
                        msaa = 8;
                        break;
                    case "16 (MSAA)":
                        msaa = 16;
                        break;
                }

                string vLang = SilDev.Initialization.ReadValue("Settings", "VoiceLang").ToLower();

                string arg = string.Empty;
                if (dMode == "fullscreen")
                    arg = "-FullScreenMode=Force ";
                if (width < 320 || height < 240)
                {
                    width = Screen.PrimaryScreen.Bounds.Width;
                    height = Screen.PrimaryScreen.Bounds.Height;
                }
                arg = string.Format("{0}-Width={1} -Height={2} -Shadow={3} -MSAA={4}", arg, width, height, shadow, msaa);
                if (vLang == "japanese")
                    arg = string.Format("{0} -VoiceJPMode", arg);

                Process[] game = Process.GetProcessesByName("ffxiii2img");
                if (game.Length <= 0)
                    SilDev.Run.App(Path.GetDirectoryName(gamePath), Path.GetFileName(gamePath), arg);

                if (dMode.Contains("windowed"))
                {
                    int usage = 0;
                    game = Process.GetProcessesByName("ffxiii2img");
                    while (usage < 40000 && game.Length > 0)
                    {
                        Thread.Sleep(10);
                        game = Process.GetProcessesByName("ffxiii2img");
                        foreach (Process ff13 in game)
                            usage = (int)ff13.NonpagedSystemMemorySize64;
                    }
                    Thread.Sleep(1000);
                    game = Process.GetProcessesByName("ffxiii2img");
                    foreach (Process ff13 in game)
                    {
                        if (dMode.Contains("borderless"))
                            SilDev.WndHook.RemoveWindowBorders(ff13.MainWindowHandle);
                        SilDev.WndHook.SetWindowSize(ff13.MainWindowHandle, width, height);
                    }
                }
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex.Message, "PlayBw_DoWork");
                e.Cancel = true;
            }
        }

        private void PlayBw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void cfgBtnPan_Click(object sender, EventArgs e)
        {
            try
            {
                cfgForm = new SettingsForm();
                cfgForm.Location = cfgFormLocation();
                cfgForm.TopLevel = false;
                cfgForm.TopMost = true;
                cfgForm.Show();

                playBtnPan.Visible = false;
                playBtnTx.Visible = false;
                cfgBtnPan.Visible = false;
                cfgBtnTx.Visible = false;
                creditsBtn.Visible = false;

                cfgPanel.Controls.Add(cfgForm);
                cfgPanel.Visible = true;

                CfgFormCloseCheck.Enabled = true;
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex.Message, "cfgBtnPan_Click");
            }
        }

        private void CfgFormCloseCheck_Tick(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                IsOpen = (f.Name == cfgForm.Name);
                if (IsOpen)
                    break;
            }
            if (!IsOpen)
            {
                cfgPanel.Visible = false;

                playBtnPan.Visible = true;
                playBtnTx.Visible = true;
                cfgBtnPan.Visible = true;
                cfgBtnTx.Visible = true;
                creditsBtn.Visible = true;

                CfgFormCloseCheck.Enabled = false;
            }
        }

        private void creditsBtn_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
            SilDev.MsgBox.Show(this, string.Format("Program developed by $î13ñ7™{0}{0}support@si13n7.com{0}{0}www.si13n7.com", Environment.NewLine), "Credits", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        #region CUSTOM LAYOUT

        public MainForm()
        {
            InitializeComponent();
            cfgPanel.Visible = false;
            cfgPanel.Location = new Point(1, 56);
            cfgPanel.Size = new Size(650, 444);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            SilDev.WndHook.MoveWindow_Mouse(this, e);
            this.Cursor = Cursors.Default;
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name != this.Name)
                    f.Location = cfgFormLocation();
        }

        private void playBtnPan_MouseEnter(object sender, EventArgs e)
        {
            playBtnPan.BackgroundImage = (Image)Properties.Resources.btn_big_mo_13;
        }

        private void playBtnPan_MouseLeave(object sender, EventArgs e)
        {
            playBtnPan.BackgroundImage = (Image)Properties.Resources.btn_big;
        }

        private void cfgBtnPan_MouseEnter(object sender, EventArgs e)
        {
            cfgBtnPan.BackgroundImage = (Image)Properties.Resources.btn_small_mo_13;
        }

        private void cfgBtnPan_MouseLeave(object sender, EventArgs e)
        {
            cfgBtnPan.BackgroundImage = (Image)Properties.Resources.btn_small;
        }

        private void closeBtnPan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeBtnPan_MouseEnter(object sender, EventArgs e)
        {
            closeBtnPan.BackgroundImage = (Image)Properties.Resources.btn_close_mo_13;
        }

        private void closeBtnPan_MouseLeave(object sender, EventArgs e)
        {
            closeBtnPan.BackgroundImage = (Image)Properties.Resources.btn_close;
        }

        private void minBtnPan_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minBtnPan_MouseEnter(object sender, EventArgs e)
        {
            minBtnPan.BackgroundImage = (Image)Properties.Resources.btn_min_mo_13;
        }

        private void minBtnPan_MouseLeave(object sender, EventArgs e)
        {
            minBtnPan.BackgroundImage = (Image)Properties.Resources.btn_min;
        }

        private Point cfgFormLocation()
        {
            return new Point(1, 0);
        }

        #endregion
    }
}
