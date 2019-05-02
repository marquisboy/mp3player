using System;
using System.Windows.Forms;
using WMPLib;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace mp3Player
{
    public enum PlayerStates
    {
        NoMedia = 0,
        Stopped = 1,
        Playing = 2,
        Paused= 3,
        Fowarding = 4,
        Reversing = 5
    }

    public partial class frmMP3Player : Form
    {
        private const string STOPPED = "Stopped";
        private const string PLAYING = "Playing";
        private const string PAUSED = "Paused";
        private const string ZERO_TIME = "00:00";
        private const int FOWARD_INCREMENT = 5;
        private const int REVERSE_INCREMENT = -5;
        private const int VOL_INC = 2;
        private const int VOL_DEC = -2;

        private PlayerConfig config;
        private int Volume { get; set; }
        private WindowsMediaPlayer player;
        private string CurrentFileName { get; set; } = "";
        private List<string> PlayList { get; set; }
        private bool Paused { get; set; } = true;
        private double CurrentPosition { get; set; }
        private Color EnabledButtonBackground { get; set; }
        private Color DisabledButtonBackground { get; set; }
        private int Increment { get; set; }
        private int VolInc = 1;
        private ProgressBarExt pbVolume;
        private PlayerStates State { get; set; }
        private int CurrentFileIndex = 0;
        private bool PlayerLoaded = false;

        public frmMP3Player()
        {
            InitializeComponent();
            config = new PlayerConfig();
            player = new WindowsMediaPlayer();
            ofdSelectFile = new OpenFileDialog();
            pbVolume = new ProgressBarExt();
            tlpVolume.Controls.Add(pbVolume, 2, 0);
            pbVolume.Dock = DockStyle.Fill;
            pbVolume.Style = ProgressBarStyle.Marquee;
            pbVolume.ForeColor = Color.Red;
            pbVolume.BackColor = Color.GreenYellow;
            PlayList = new List<string>();

            EnabledButtonBackground = Color.FromArgb(209, 210, 212);
            DisabledButtonBackground = Color.FromArgb(116, 110, 101);
            State = PlayerStates.NoMedia;
            if ( PlayerConfig.Initialized ) LoadConfigValues(config);
        }

        private void LoadConfigValues(PlayerConfig config )
        {
            this.Top = config.Top;
            this.Left = config.Left;
            this.Width = (config.Width==0)?400:config.Width;
            this.Height = (config.Height==0)?250:config.Height;
            pbVolume.Value = config.Volume;
            Volume = config.Volume;
            CurrentFileName = config.LastMediaFileName;
            CurrentFileIndex = config.CurrentFileIndex;
            if (CurrentFileName != null && CurrentFileName != "" )
            {
                player.URL = CurrentFileName;
                txtMediaName.Text = GetFileNameFromURL(CurrentFileName);
                PlayList = config.MediaPlayList;
                player.controls.play();
                System.Threading.Thread.Sleep(1000);
                player.controls.pause();
                CurrentPosition = config.LastMediaPosition;
                player.controls.currentPosition = CurrentPosition;
                SetButtonState(true);
                State = PlayerStates.Paused;
                tmrPlayTick.Enabled = false;
            }
            else
            {
                txtCurrentTime.Text = ZERO_TIME;
                txtMediaName.Text = "";
                State = PlayerStates.Stopped;
                tmrPlayTick.Enabled = false;
                SetButtonState(false);
                player.controls.stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (config.LastMediaFileName != null && config.LastMediaFileName != "")
            {
                player.controls.stop();
                txtCurrentTime.Text = "00:00";
                lblMediaName.Text = STOPPED;
            }
            else
            {
                player.controls.pause();
                txtCurrentTime.Text = player.controls.currentPositionString;
                lblMediaName.Text = PAUSED;
            }
            PlayerLoaded = true;
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            ofdSelectFile.DefaultExt = "mp3";
            ofdSelectFile.Multiselect = true;
            DialogResult result = ofdSelectFile.ShowDialog();
            if (ofdSelectFile.FileNames.Length > 0)
            {
                PlayList = new List<string>();
                foreach (var name in ofdSelectFile.FileNames)
                {
                    PlayList.Add(name);
                }
                CurrentFileName = PlayList[0];
                player.URL = CurrentFileName;
                player.controls.play();
                System.Threading.Thread.Sleep(1000);
                txtMediaName.Text = player.currentMedia.name;
                tbFileProgress.Maximum = 100;
                tbFileProgress.Minimum = 0;
                tbFileProgress.SmallChange = 1;
                tbFileProgress.TickFrequency = 5;
                tbFileProgress.Value = 0;
                player.controls.stop();
                SetButtonState(true);
                txtCurrentTime.Text = player.controls.currentPositionString;
                PlayerLoaded = true;
            }
            State = PlayerStates.Paused;
        }

        private void SetButtonState(bool enabled)
        {
            if ( enabled)
            {
                btnRewind.BackgroundImage = Properties.Resources.Rewind2;
                btnPlay.BackgroundImage = Properties.Resources.play2;
                btnFoward.BackgroundImage = Properties.Resources.FastFoward2;
                btnGoStart.BackgroundImage = Properties.Resources.GotoStart2;
                btnGotoEnd.BackgroundImage = Properties.Resources.GotoEnd2;
            }
            else
            {
                btnRewind.BackgroundImage = Properties.Resources.Rewind_disabled;
                btnPlay.BackgroundImage = Properties.Resources.play_disabled;
                btnFoward.BackgroundImage = Properties.Resources.FastFoward_disabled;
                btnGoStart.BackgroundImage = Properties.Resources.GotoStart_disabled;
                btnGotoEnd.BackgroundImage = Properties.Resources.GotoEnd_disabled;
            }
            btnRewind.Enabled = enabled;
            btnPlay.Enabled = enabled;
            btnFoward.Enabled = enabled;
            tlpButtons.BackColor = EnabledButtonBackground;
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        private void Shutdown()
        {
            config.SaveConfig(this.Top, this.Left, this.Width, this.Height, CurrentFileName, CurrentFileIndex, PlayList, player.controls.currentPosition, pbVolume.Value );
            player = null;
            ofdSelectFile = null;
            this.Close();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if ( Paused)
            {
                player.controls.play();
                Paused = false;
                btnPlay.BackgroundImage = Properties.Resources.Pause2;
                lblMediaName.Text = PLAYING;
                tmrPlayTick.Enabled = true;
                State = PlayerStates.Playing;
            }
            else
            {
                player.controls.pause();
                Paused = true;
                btnPlay.BackgroundImage = Properties.Resources.play2;
                CurrentPosition = player.controls.currentPosition;
                lblMediaName.Text = PAUSED;
                tmrPlayTick.Enabled = false;
                State = PlayerStates.Paused;
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            btnPlay.BackgroundImage = Properties.Resources.play2;
            Paused = true;
            lblMediaName.Text = STOPPED;
            tmrPlayTick.Enabled = false;
            txtCurrentTime.Text = ZERO_TIME;
            State = PlayerStates.Stopped;
        }

        private string GetFileNameFromURL(string filename )
        {
            string fname;

            if (filename.Contains("\\"))
            {
                fname = filename.Substring(filename.LastIndexOf(@"\") + 1, ( filename.Length - filename.LastIndexOf(@"\") ) - 1);
            }
            else
            {
                fname = filename;
            }

            return fname;
        }

        private void TmrPlayTick_Tick(object sender, EventArgs e)
        {
            if (PlayerLoaded)
            {
                txtCurrentTime.Text = player.controls.currentPositionString;
                if (player.currentMedia.duration > 0)
                {
                    tbFileProgress.Value = (int)(Math.Round((player.controls.currentPosition / player.currentMedia.duration) * 100));
                }
                if (player.controls.currentPosition >= player.currentMedia.duration - 1 && CurrentFileIndex < PlayList.Count - 1)
                {
                    CurrentFileName = PlayList[++CurrentFileIndex];
                    player.URL = CurrentFileName;
                    player.controls.play();
                    txtMediaName.Text = player.currentMedia.name;
                }
            }
        }

        private void BtnFoward_MouseUp(object sender, MouseEventArgs e)
        {
            tmrIncrementTick.Enabled = false;
        }

        private void TmrIncrementTick_Tick(object sender, EventArgs e)
        {
            if ( ( player.controls.currentPosition + Increment) > 0 )
                player.controls.currentPosition += Increment;
        }

        private void BtnFoward_MouseDown(object sender, MouseEventArgs e)
        {
            switch (State)
            {
                case PlayerStates.Reversing:
                case PlayerStates.Paused:
                case PlayerStates.Playing:
                    tmrIncrementTick.Enabled = true;
                    Increment = FOWARD_INCREMENT;
                    player.controls.currentPosition += Increment;
                    break;
            }
        }

        private void BtnRewind_MouseDown(object sender, MouseEventArgs e)
        {
            switch (State)
            {
                case PlayerStates.Fowarding:
                case PlayerStates.Paused:
                case PlayerStates.Playing:
                    tmrIncrementTick.Enabled = true;
                    Increment = REVERSE_INCREMENT;
                    player.controls.currentPosition += Increment;
                    break;
            }
        }

        private void BtnRewind_MouseUp(object sender, MouseEventArgs e)
        {
            tmrIncrementTick.Enabled = false;
        }

        private void BtnResetConfig_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Reset to Defaults", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if ( result == DialogResult.Yes)
            {
                config.ResetConfig();
                LoadConfigValues(config);
            }
        }

        private void btnGoStart_Click(object sender, EventArgs e)
        {
            if ( CurrentFileIndex > 0)
            {
                CurrentFileName = PlayList[--CurrentFileIndex];
                if (CurrentFileIndex < PlayList.Count)
                {
                    btnGotoEnd.BackgroundImage = Properties.Resources.GotoEnd2;
                    btnGotoEnd.Enabled = true;
                }
            }
            else
            {
                CurrentFileName = PlayList[0];
                CurrentFileIndex = 0;
            }

            if (CurrentFileIndex == 0)
            {
                btnGoStart.BackgroundImage = Properties.Resources.GotoStart_disabled;
                btnGoStart.Enabled = false;
            }
            player.URL = CurrentFileName;
            txtMediaName.Text = player.currentMedia.name;
            player.controls.currentPosition = 0.0f;
            txtCurrentTime.Text = ZERO_TIME;
            player.controls.play();
        }

        private void btnGotoEnd_Click(object sender, EventArgs e)
        {
            if (CurrentFileIndex < PlayList.Count-1)
            {
                CurrentFileName = PlayList[++CurrentFileIndex];
                btnGoStart.BackgroundImage = Properties.Resources.GotoStart2;
                btnGoStart.Enabled = true;
            }
            else
            {
                CurrentFileName = PlayList[PlayList.Count - 1];
                CurrentFileIndex = PlayList.Count - 1;
            }
            if (CurrentFileIndex == PlayList.Count - 1)
            {
                btnGotoEnd.BackgroundImage = Properties.Resources.GotoEnd_disabled;
                btnGotoEnd.Enabled = false;
            }
            player.URL = CurrentFileName;
            player.controls.play();
            txtMediaName.Text = player.currentMedia.name;// GetFileNameFromURL(FileName);
            player.controls.currentPosition = 0;// player.currentMedia.duration;
            txtCurrentTime.Text = player.currentMedia.duration.ToString();
        }

        private void UpdateVolume( )
        {
            pbVolume.Value = Volume;
            player.settings.volume = pbVolume.Value;
            pbVolume.ForeColor = Color.FromArgb(209 - pbVolume.Value, 110 + pbVolume.Value, 100);
        }


        private void btnVolumeDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (Volume > 1)
            {
                VolInc = VOL_DEC;
                tmrVolume.Enabled = true;
                pbVolume.DoPaintEvent = true;
            }
        }

        private void tmrVolume_Tick(object sender, EventArgs e)
        {
            Volume += VolInc;
            if (Volume > 100) Volume = 100;
            if (Volume < 0) Volume = 0;
            UpdateVolume();
        }

        private void btnVolumeDown_MouseUp(object sender, MouseEventArgs e)
        {
            tmrVolume.Enabled = false;
            pbVolume.DoPaintEvent = false;
        }

        private void btnVolumeUp_MouseUp(object sender, MouseEventArgs e)
        {
            tmrVolume.Enabled = false;
            pbVolume.DoPaintEvent = false;
        }

        private void btnVolumeUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (Volume < 99)
            {
                VolInc = VOL_INC;
                tmrVolume.Enabled = true;
                pbVolume.DoPaintEvent = true;
            }
        }

        private void tbFileProgress_Scroll(object sender, EventArgs e)
        {
            player.controls.currentPosition = (((double)tbFileProgress.Value)/((double)tbFileProgress.Maximum)) * player.currentMedia.duration;
        }
    }
}
