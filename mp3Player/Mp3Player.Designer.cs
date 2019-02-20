namespace mp3Player
{
    partial class frmMP3Player
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFunctions = new System.Windows.Forms.TableLayoutPanel();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnGoStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnFoward = new System.Windows.Forms.Button();
            this.btnRewind = new System.Windows.Forms.Button();
            this.btnGotoEnd = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tlpCurrentMedia = new System.Windows.Forms.TableLayoutPanel();
            this.txtMediaName = new System.Windows.Forms.TextBox();
            this.lblMediaName = new System.Windows.Forms.Label();
            this.tlpVolume = new System.Windows.Forms.TableLayoutPanel();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.tbFileProgress = new System.Windows.Forms.TrackBar();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.tmrPlayTick = new System.Windows.Forms.Timer(this.components);
            this.tmrIncrementTick = new System.Windows.Forms.Timer(this.components);
            this.tmrVolume = new System.Windows.Forms.Timer(this.components);
            this.ckbBreak = new System.Windows.Forms.CheckBox();
            this.tlpMain.SuspendLayout();
            this.tlpFunctions.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpCurrentMedia.SuspendLayout();
            this.tlpVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFileProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Black;
            this.tlpMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpFunctions, 0, 0);
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 3);
            this.tlpMain.Controls.Add(this.tlpCurrentMedia, 0, 4);
            this.tlpMain.Controls.Add(this.tlpVolume, 0, 2);
            this.tlpMain.Controls.Add(this.tbFileProgress, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(1);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.Size = new System.Drawing.Size(401, 213);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpFunctions
            // 
            this.tlpFunctions.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpFunctions.ColumnCount = 4;
            this.tlpFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.62753F));
            this.tlpFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.34008F));
            this.tlpFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.03239F));
            this.tlpFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpFunctions.Controls.Add(this.btnResetConfig, 0, 0);
            this.tlpFunctions.Controls.Add(this.txtCurrentTime, 2, 0);
            this.tlpFunctions.Controls.Add(this.btnLoadFile, 0, 0);
            this.tlpFunctions.Controls.Add(this.ckbBreak, 3, 0);
            this.tlpFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFunctions.Location = new System.Drawing.Point(4, 4);
            this.tlpFunctions.Margin = new System.Windows.Forms.Padding(1);
            this.tlpFunctions.Name = "tlpFunctions";
            this.tlpFunctions.RowCount = 1;
            this.tlpFunctions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFunctions.Size = new System.Drawing.Size(393, 33);
            this.tlpFunctions.TabIndex = 1;
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetConfig.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetConfig.Location = new System.Drawing.Point(90, 2);
            this.btnResetConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(68, 29);
            this.btnResetConfig.TabIndex = 1;
            this.btnResetConfig.Text = "Presets";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.BtnResetConfig_Click);
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.Color.Black;
            this.txtCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTime.ForeColor = System.Drawing.Color.Yellow;
            this.txtCurrentTime.Location = new System.Drawing.Point(161, 2);
            this.txtCurrentTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 10);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(85, 17);
            this.txtCurrentTime.TabIndex = 2;
            this.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadFile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.Location = new System.Drawing.Point(2, 2);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(86, 29);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpButtons.ColumnCount = 7;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28428F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29431F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28428F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28428F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28428F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28428F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28428F));
            this.tlpButtons.Controls.Add(this.btnGoStart, 0, 0);
            this.tlpButtons.Controls.Add(this.btnStop, 0, 0);
            this.tlpButtons.Controls.Add(this.btnPower, 6, 0);
            this.tlpButtons.Controls.Add(this.btnFoward, 4, 0);
            this.tlpButtons.Controls.Add(this.btnRewind, 2, 0);
            this.tlpButtons.Controls.Add(this.btnGotoEnd, 4, 0);
            this.tlpButtons.Controls.Add(this.btnPlay, 3, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 112);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(395, 60);
            this.tlpButtons.TabIndex = 0;
            // 
            // btnGoStart
            // 
            this.btnGoStart.BackgroundImage = global::mp3Player.Properties.Resources.GotoStart_disabled;
            this.btnGoStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoStart.Location = new System.Drawing.Point(58, 2);
            this.btnGoStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnGoStart.Name = "btnGoStart";
            this.btnGoStart.Size = new System.Drawing.Size(54, 56);
            this.btnGoStart.TabIndex = 5;
            this.btnGoStart.UseVisualStyleBackColor = true;
            this.btnGoStart.Click += new System.EventHandler(this.btnGoStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::mp3Player.Properties.Resources.Stop2;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(2, 2);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(54, 56);
            this.btnStop.TabIndex = 0;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnPower
            // 
            this.btnPower.BackgroundImage = global::mp3Player.Properties.Resources.power2;
            this.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPower.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPower.Location = new System.Drawing.Point(338, 2);
            this.btnPower.Margin = new System.Windows.Forms.Padding(0);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(55, 56);
            this.btnPower.TabIndex = 4;
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // btnFoward
            // 
            this.btnFoward.BackgroundImage = global::mp3Player.Properties.Resources.FastFoward_disabled;
            this.btnFoward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFoward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFoward.Enabled = false;
            this.btnFoward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFoward.Location = new System.Drawing.Point(226, 2);
            this.btnFoward.Margin = new System.Windows.Forms.Padding(0);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(54, 56);
            this.btnFoward.TabIndex = 3;
            this.btnFoward.UseVisualStyleBackColor = true;
            this.btnFoward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFoward_MouseDown);
            this.btnFoward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFoward_MouseUp);
            // 
            // btnRewind
            // 
            this.btnRewind.BackgroundImage = global::mp3Player.Properties.Resources.Rewind_disabled;
            this.btnRewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRewind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRewind.Enabled = false;
            this.btnRewind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRewind.Location = new System.Drawing.Point(114, 2);
            this.btnRewind.Margin = new System.Windows.Forms.Padding(0);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(54, 56);
            this.btnRewind.TabIndex = 1;
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRewind_MouseDown);
            this.btnRewind.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRewind_MouseUp);
            // 
            // btnGotoEnd
            // 
            this.btnGotoEnd.BackgroundImage = global::mp3Player.Properties.Resources.GotoEnd_disabled;
            this.btnGotoEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGotoEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGotoEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGotoEnd.Location = new System.Drawing.Point(282, 2);
            this.btnGotoEnd.Margin = new System.Windows.Forms.Padding(0);
            this.btnGotoEnd.Name = "btnGotoEnd";
            this.btnGotoEnd.Size = new System.Drawing.Size(54, 56);
            this.btnGotoEnd.TabIndex = 6;
            this.btnGotoEnd.UseVisualStyleBackColor = true;
            this.btnGotoEnd.Click += new System.EventHandler(this.btnGotoEnd_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::mp3Player.Properties.Resources.play_disabled;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.Enabled = false;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Location = new System.Drawing.Point(170, 2);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(54, 56);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // tlpCurrentMedia
            // 
            this.tlpCurrentMedia.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpCurrentMedia.ColumnCount = 2;
            this.tlpCurrentMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpCurrentMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCurrentMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCurrentMedia.Controls.Add(this.txtMediaName, 1, 0);
            this.tlpCurrentMedia.Controls.Add(this.lblMediaName, 0, 0);
            this.tlpCurrentMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCurrentMedia.Location = new System.Drawing.Point(4, 176);
            this.tlpCurrentMedia.Margin = new System.Windows.Forms.Padding(1);
            this.tlpCurrentMedia.Name = "tlpCurrentMedia";
            this.tlpCurrentMedia.RowCount = 1;
            this.tlpCurrentMedia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCurrentMedia.Size = new System.Drawing.Size(393, 33);
            this.tlpCurrentMedia.TabIndex = 2;
            // 
            // txtMediaName
            // 
            this.txtMediaName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMediaName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMediaName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaName.ForeColor = System.Drawing.Color.Navy;
            this.txtMediaName.Location = new System.Drawing.Point(96, 2);
            this.txtMediaName.Margin = new System.Windows.Forms.Padding(0);
            this.txtMediaName.Multiline = true;
            this.txtMediaName.Name = "txtMediaName";
            this.txtMediaName.Size = new System.Drawing.Size(295, 29);
            this.txtMediaName.TabIndex = 1;
            // 
            // lblMediaName
            // 
            this.lblMediaName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMediaName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMediaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaName.ForeColor = System.Drawing.Color.Lime;
            this.lblMediaName.Location = new System.Drawing.Point(2, 2);
            this.lblMediaName.Margin = new System.Windows.Forms.Padding(0);
            this.lblMediaName.Name = "lblMediaName";
            this.lblMediaName.Size = new System.Drawing.Size(92, 29);
            this.lblMediaName.TabIndex = 0;
            this.lblMediaName.Text = "Stopped";
            this.lblMediaName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpVolume
            // 
            this.tlpVolume.ColumnCount = 3;
            this.tlpVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVolume.Controls.Add(this.btnVolumeUp, 1, 0);
            this.tlpVolume.Controls.Add(this.btnVolumeDown, 0, 0);
            this.tlpVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVolume.Location = new System.Drawing.Point(6, 77);
            this.tlpVolume.Name = "tlpVolume";
            this.tlpVolume.RowCount = 1;
            this.tlpVolume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVolume.Size = new System.Drawing.Size(389, 29);
            this.tlpVolume.TabIndex = 4;
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVolumeUp.BackgroundImage = global::mp3Player.Properties.Resources.volume_up1;
            this.btnVolumeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolumeUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVolumeUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnVolumeUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolumeUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolumeUp.Location = new System.Drawing.Point(40, 0);
            this.btnVolumeUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(40, 29);
            this.btnVolumeUp.TabIndex = 6;
            this.btnVolumeUp.UseVisualStyleBackColor = false;
            this.btnVolumeUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVolumeUp_MouseDown);
            this.btnVolumeUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVolumeUp_MouseUp);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVolumeDown.BackgroundImage = global::mp3Player.Properties.Resources.volume_down;
            this.btnVolumeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolumeDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVolumeDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnVolumeDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolumeDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolumeDown.Location = new System.Drawing.Point(0, 0);
            this.btnVolumeDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(40, 29);
            this.btnVolumeDown.TabIndex = 5;
            this.btnVolumeDown.UseVisualStyleBackColor = false;
            this.btnVolumeDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVolumeDown_MouseDown);
            this.btnVolumeDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVolumeDown_MouseUp);
            // 
            // tbFileProgress
            // 
            this.tbFileProgress.BackColor = System.Drawing.Color.DimGray;
            this.tbFileProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFileProgress.Location = new System.Drawing.Point(4, 42);
            this.tbFileProgress.Margin = new System.Windows.Forms.Padding(1);
            this.tbFileProgress.Maximum = 100;
            this.tbFileProgress.Name = "tbFileProgress";
            this.tbFileProgress.Size = new System.Drawing.Size(393, 28);
            this.tbFileProgress.TabIndex = 5;
            this.tbFileProgress.Scroll += new System.EventHandler(this.tbFileProgress_Scroll);
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.FileName = "openFileDialog1";
            // 
            // tmrPlayTick
            // 
            this.tmrPlayTick.Interval = 1000;
            this.tmrPlayTick.Tick += new System.EventHandler(this.TmrPlayTick_Tick);
            // 
            // tmrIncrementTick
            // 
            this.tmrIncrementTick.Interval = 10;
            this.tmrIncrementTick.Tick += new System.EventHandler(this.TmrIncrementTick_Tick);
            // 
            // tmrVolume
            // 
            this.tmrVolume.Interval = 20;
            this.tmrVolume.Tick += new System.EventHandler(this.tmrVolume_Tick);
            // 
            // ckbBreak
            // 
            this.ckbBreak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbBreak.Location = new System.Drawing.Point(252, 5);
            this.ckbBreak.Name = "ckbBreak";
            this.ckbBreak.Size = new System.Drawing.Size(133, 23);
            this.ckbBreak.TabIndex = 3;
            this.ckbBreak.Text = "Break";
            this.ckbBreak.UseVisualStyleBackColor = true;
            // 
            // frmMP3Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnPower;
            this.ClientSize = new System.Drawing.Size(401, 213);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMP3Player";
            this.Text = "Joe MP3 Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpFunctions.ResumeLayout(false);
            this.tlpFunctions.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpCurrentMedia.ResumeLayout(false);
            this.tlpCurrentMedia.PerformLayout();
            this.tlpVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbFileProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnFoward;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TableLayoutPanel tlpFunctions;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.TableLayoutPanel tlpCurrentMedia;
        private System.Windows.Forms.Label lblMediaName;
        private System.Windows.Forms.TextBox txtMediaName;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.Timer tmrPlayTick;
        private System.Windows.Forms.Timer tmrIncrementTick;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Button btnGoStart;
        private System.Windows.Forms.Button btnGotoEnd;
        private System.Windows.Forms.TableLayoutPanel tlpVolume;
        //private System.Windows.Forms.ProgressBar pbVolume;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Timer tmrVolume;
        private System.Windows.Forms.TrackBar tbFileProgress;
        private System.Windows.Forms.CheckBox ckbBreak;
    }
}

