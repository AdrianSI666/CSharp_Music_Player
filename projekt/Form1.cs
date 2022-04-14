using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;
using WMPLib;

namespace projekt
{
    public partial class Form1 : Form
    {
        private List<string> directorys=new List<string>();
        Timer t = new Timer();
        IWMPMedia mediaInfo;
        private bool repeat = false;
        public Form1()
        {
            InitializeComponent();
            visuali.uiMode = "none";
            SetCurrentEffectPreset(2);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if(FBD.ShowDialog()== DialogResult.OK)
            {
                MusicFiles.Items.Clear();
                string[] files = Directory.GetFiles(FBD.SelectedPath,"*.mp3");
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);
                loopForFiles(files);
                loopForDirs(dirs);
            }
        }

        private void loopForFiles(string[] files)
        {
            foreach (string file in files)
            {
                directorys.Add(file);
                string[] fileso = file.Split('\\');
                MusicFiles.Items.Add(fileso[fileso.Length - 1]);
            }
        }

        private void loopForDirs(string[] dirs)
        {
            foreach (string dir in dirs)
            {
                string[] files = Directory.GetFiles(dir, "*.mp3");
                loopForFiles(files);
                string[] dirs2 = Directory.GetDirectories(dir);
                loopForDirs(dirs2);
            }
        }

        private void MusicFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                mediaInfo = visuali.newMedia(directorys[MusicFiles.SelectedIndex]);
                visuali.URL = directorys[MusicFiles.SelectedIndex];                
                t.Interval = 1000;
                t.Tick += new EventHandler(t_Tick);
                visuali.Ctlcontrols.play();
                TrackBar.Maximum = (int)Math.Floor(mediaInfo.duration);
                timeRemaining.Text = mediaInfo.durationString;
                t.Start();
            }
            catch { }
        }
        void t_Tick(object sender, EventArgs e)
        {
            TrackBar.Value = (int)this.visuali.Ctlcontrols.currentPosition;
            if ((int)this.visuali.Ctlcontrols.currentPosition < 60)
            {
                currentTime.Text = ("0:"+ (int)this.visuali.Ctlcontrols.currentPosition);
            }
            else
            {
                currentTime.Text = (Math.Floor(this.visuali.Ctlcontrols.currentPosition / 60)+":" + Math.Floor((this.visuali.Ctlcontrols.currentPosition - 60* Math.Floor(this.visuali.Ctlcontrols.currentPosition / 60))));
            }
            if (Math.Floor(this.visuali.Ctlcontrols.currentPosition)+1 >= Math.Floor(mediaInfo.duration)) {
                System.Threading.Thread.Sleep(100);
                if (repeat)
                {
                    MusicFiles.SelectedIndex = MusicFiles.SelectedIndex-1;
                    MusicFiles.SelectedIndex = MusicFiles.SelectedIndex+1;
                }
                else
                {
                    if (MusicFiles.SelectedIndex + 1 >= MusicFiles.Items.Count)
                    {
                        MusicFiles.SelectedIndex = 0;
                    }
                    else
                    {
                        MusicFiles.SelectedIndex = MusicFiles.SelectedIndex + 1;
                    }
                }
            }
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            visuali.Ctlcontrols.pause();
            visuali.Ctlcontrols.currentPosition = (double)TrackBar.Value;
            System.Threading.Thread.Sleep(100);
            visuali.Ctlcontrols.play();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            visuali.Ctlcontrols.pause();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            visuali.Ctlcontrols.play();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (t.Enabled)
            {
                if (MusicFiles.SelectedIndex + 1 >= MusicFiles.Items.Count)
                {
                    MusicFiles.SelectedIndex = 0;
                }
                else
                {
                    MusicFiles.SelectedIndex = MusicFiles.SelectedIndex + 1;
                }
            }
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            if (t.Enabled)
            {
                if (MusicFiles.SelectedIndex - 1 < 0)
                {
                    MusicFiles.SelectedIndex = MusicFiles.Items.Count - 1;
                }
                else
                {
                    MusicFiles.SelectedIndex = MusicFiles.SelectedIndex - 1;
                }
            }
        }

        private void Repeat_Click(object sender, EventArgs e)
        {
            repeat = !repeat;
            if (repeat)LRepeat.Text = "Repeat is: On";
            else LRepeat.Text = "Repeat is: Off";
        }
        public void SetCurrentEffectPreset(int value)
        {
            WindowsIdentity identiry = WindowsIdentity.GetCurrent();
            String path = String.Format(@"{0}\Software\Microsoft\MediaPlayer\Preferences", identiry.User.Value);
            RegistryKey key = Registry.Users.OpenSubKey(path, true);
            if (key == null)
                throw new Exception("Registry key not found!");
            key.SetValue("CurrentEffectPreset", value, RegistryValueKind.DWord);
        }
    }
}
