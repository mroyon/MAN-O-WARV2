namespace Digi_Com.AppForms
{
    partial class frmMakeCall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMakeCall));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkListStations = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.volumeSlider1 = new NAudio.Gui.VolumeSlider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelNowTime = new System.Windows.Forms.Label();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecordAudio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboWaveInDevice = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnStopRecording = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboWasapiLoopbackDevices = new System.Windows.Forms.ComboBox();
            this.radioButtonWaveIn = new System.Windows.Forms.RadioButton();
            this.comboWasapiDevices = new System.Windows.Forms.ComboBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timerResponse = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.flowLayoutPanel1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkListStations);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 244);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // chkListStations
            // 
            this.chkListStations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListStations.FormattingEnabled = true;
            this.chkListStations.Location = new System.Drawing.Point(5, 5);
            this.chkListStations.Margin = new System.Windows.Forms.Padding(5);
            this.chkListStations.Name = "chkListStations";
            this.chkListStations.Size = new System.Drawing.Size(149, 165);
            this.chkListStations.TabIndex = 2;
            this.chkListStations.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListStations_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Digi_Com.Properties.Resources.LeftBanner;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 299);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Station List";
            // 
            // btnPlay
            // 
            this.btnPlay.Active = false;
            this.btnPlay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.BorderRadius = 0;
            this.btnPlay.ButtonText = "Play";
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlay.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlay.Iconimage")));
            this.btnPlay.Iconimage_right = null;
            this.btnPlay.Iconimage_right_Selected = null;
            this.btnPlay.Iconimage_Selected = null;
            this.btnPlay.IconMarginLeft = 0;
            this.btnPlay.IconMarginRight = 0;
            this.btnPlay.IconRightVisible = true;
            this.btnPlay.IconRightZoom = 0D;
            this.btnPlay.IconVisible = true;
            this.btnPlay.IconZoom = 90D;
            this.btnPlay.IsTab = false;
            this.btnPlay.Location = new System.Drawing.Point(328, 50);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPlay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPlay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlay.selected = false;
            this.btnPlay.Size = new System.Drawing.Size(163, 48);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.Textcolor = System.Drawing.Color.White;
            this.btnPlay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Location = new System.Drawing.Point(236, 22);
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.Size = new System.Drawing.Size(115, 20);
            this.volumeSlider1.TabIndex = 6;
            this.volumeSlider1.VolumeChanged += new System.EventHandler(this.volumeSlider1_VolumeChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalTime.ForeColor = System.Drawing.Color.White;
            this.labelTotalTime.Location = new System.Drawing.Point(317, 6);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(34, 13);
            this.labelTotalTime.TabIndex = 7;
            this.labelTotalTime.Text = "00:00";
            // 
            // labelNowTime
            // 
            this.labelNowTime.AutoSize = true;
            this.labelNowTime.BackColor = System.Drawing.Color.Transparent;
            this.labelNowTime.ForeColor = System.Drawing.Color.White;
            this.labelNowTime.Location = new System.Drawing.Point(268, 6);
            this.labelNowTime.Name = "labelNowTime";
            this.labelNowTime.Size = new System.Drawing.Size(34, 13);
            this.labelNowTime.TabIndex = 8;
            this.labelNowTime.Text = "00:00";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Active = false;
            this.btnBrowse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.BorderRadius = 0;
            this.btnBrowse.ButtonText = "Select Audio";
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Iconimage")));
            this.btnBrowse.Iconimage_right = null;
            this.btnBrowse.Iconimage_right_Selected = null;
            this.btnBrowse.Iconimage_Selected = null;
            this.btnBrowse.IconMarginLeft = 0;
            this.btnBrowse.IconMarginRight = 0;
            this.btnBrowse.IconRightVisible = true;
            this.btnBrowse.IconRightZoom = 0D;
            this.btnBrowse.IconVisible = true;
            this.btnBrowse.IconZoom = 90D;
            this.btnBrowse.IsTab = false;
            this.btnBrowse.Location = new System.Drawing.Point(188, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowse.selected = false;
            this.btnBrowse.Size = new System.Drawing.Size(134, 48);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Select Audio";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Textcolor = System.Drawing.Color.White;
            this.btnBrowse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(188, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Playback Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(188, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Volume";
            // 
            // btnRecordAudio
            // 
            this.btnRecordAudio.Active = false;
            this.btnRecordAudio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRecordAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRecordAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecordAudio.BorderRadius = 0;
            this.btnRecordAudio.ButtonText = "Start Recording";
            this.btnRecordAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordAudio.DisabledColor = System.Drawing.Color.Gray;
            this.btnRecordAudio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecordAudio.Iconimage = global::Digi_Com.Properties.Resources.microphone;
            this.btnRecordAudio.Iconimage_right = null;
            this.btnRecordAudio.Iconimage_right_Selected = null;
            this.btnRecordAudio.Iconimage_Selected = null;
            this.btnRecordAudio.IconMarginLeft = 0;
            this.btnRecordAudio.IconMarginRight = 0;
            this.btnRecordAudio.IconRightVisible = true;
            this.btnRecordAudio.IconRightZoom = 0D;
            this.btnRecordAudio.IconVisible = true;
            this.btnRecordAudio.IconZoom = 80D;
            this.btnRecordAudio.IsTab = false;
            this.btnRecordAudio.Location = new System.Drawing.Point(6, 20);
            this.btnRecordAudio.Name = "btnRecordAudio";
            this.btnRecordAudio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRecordAudio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRecordAudio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRecordAudio.selected = false;
            this.btnRecordAudio.Size = new System.Drawing.Size(142, 37);
            this.btnRecordAudio.TabIndex = 13;
            this.btnRecordAudio.Text = "Start Recording";
            this.btnRecordAudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecordAudio.Textcolor = System.Drawing.Color.White;
            this.btnRecordAudio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordAudio.Click += new System.EventHandler(this.btnRecordAudio_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 144);
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(164, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // comboWaveInDevice
            // 
            this.comboWaveInDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWaveInDevice.FormattingEnabled = true;
            this.comboWaveInDevice.Location = new System.Drawing.Point(6, 63);
            this.comboWaveInDevice.Name = "comboWaveInDevice";
            this.comboWaveInDevice.Size = new System.Drawing.Size(164, 21);
            this.comboWaveInDevice.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSendFile);
            this.groupBox1.Controls.Add(this.btnStopRecording);
            this.groupBox1.Controls.Add(this.comboWasapiLoopbackDevices);
            this.groupBox1.Controls.Add(this.radioButtonWaveIn);
            this.groupBox1.Controls.Add(this.comboWasapiDevices);
            this.groupBox1.Controls.Add(this.btnRecordAudio);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.comboWaveInDevice);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(188, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 179);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Panel";
            // 
            // btnSendFile
            // 
            this.btnSendFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSendFile.Enabled = false;
            this.btnSendFile.ForeColor = System.Drawing.Color.Black;
            this.btnSendFile.Location = new System.Drawing.Point(176, 96);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(120, 71);
            this.btnSendFile.TabIndex = 23;
            this.btnSendFile.Text = "Call And Send File";
            this.btnSendFile.UseVisualStyleBackColor = false;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Active = false;
            this.btnStopRecording.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStopRecording.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStopRecording.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStopRecording.BorderRadius = 0;
            this.btnStopRecording.ButtonText = "Stop Recording";
            this.btnStopRecording.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopRecording.DisabledColor = System.Drawing.Color.Gray;
            this.btnStopRecording.Enabled = false;
            this.btnStopRecording.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStopRecording.Iconimage = global::Digi_Com.Properties.Resources.microphone;
            this.btnStopRecording.Iconimage_right = null;
            this.btnStopRecording.Iconimage_right_Selected = null;
            this.btnStopRecording.Iconimage_Selected = null;
            this.btnStopRecording.IconMarginLeft = 0;
            this.btnStopRecording.IconMarginRight = 0;
            this.btnStopRecording.IconRightVisible = true;
            this.btnStopRecording.IconRightZoom = 0D;
            this.btnStopRecording.IconVisible = true;
            this.btnStopRecording.IconZoom = 80D;
            this.btnStopRecording.IsTab = false;
            this.btnStopRecording.Location = new System.Drawing.Point(154, 19);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStopRecording.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnStopRecording.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStopRecording.selected = false;
            this.btnStopRecording.Size = new System.Drawing.Size(142, 37);
            this.btnStopRecording.TabIndex = 22;
            this.btnStopRecording.Text = "Stop Recording";
            this.btnStopRecording.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopRecording.Textcolor = System.Drawing.Color.White;
            this.btnStopRecording.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // comboWasapiLoopbackDevices
            // 
            this.comboWasapiLoopbackDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWasapiLoopbackDevices.FormattingEnabled = true;
            this.comboWasapiLoopbackDevices.Location = new System.Drawing.Point(6, 117);
            this.comboWasapiLoopbackDevices.Name = "comboWasapiLoopbackDevices";
            this.comboWasapiLoopbackDevices.Size = new System.Drawing.Size(164, 21);
            this.comboWasapiLoopbackDevices.TabIndex = 21;
            // 
            // radioButtonWaveIn
            // 
            this.radioButtonWaveIn.AutoSize = true;
            this.radioButtonWaveIn.Checked = true;
            this.radioButtonWaveIn.Location = new System.Drawing.Point(212, 64);
            this.radioButtonWaveIn.Name = "radioButtonWaveIn";
            this.radioButtonWaveIn.Size = new System.Drawing.Size(60, 17);
            this.radioButtonWaveIn.TabIndex = 20;
            this.radioButtonWaveIn.TabStop = true;
            this.radioButtonWaveIn.Text = "waveIn";
            this.radioButtonWaveIn.UseVisualStyleBackColor = true;
            this.radioButtonWaveIn.Visible = false;
            // 
            // comboWasapiDevices
            // 
            this.comboWasapiDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWasapiDevices.FormattingEnabled = true;
            this.comboWasapiDevices.Location = new System.Drawing.Point(6, 90);
            this.comboWasapiDevices.Name = "comboWasapiDevices";
            this.comboWasapiDevices.Size = new System.Drawing.Size(164, 21);
            this.comboWasapiDevices.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.Active = false;
            this.btnClose.Activecolor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = global::Digi_Com.Properties.Resources.close;
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 50D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(461, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(25, 28);
            this.btnClose.TabIndex = 18;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerResponse
            // 
            this.timerResponse.Interval = 20000;
            this.timerResponse.Tick += new System.EventHandler(this.timerResponse_Tick);
            // 
            // frmMakeCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Digi_Com.Properties.Resources.Login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(498, 295);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelNowTime);
            this.Controls.Add(this.volumeSlider1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMakeCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Make a Call";
            this.Load += new System.EventHandler(this.frmMakeCall_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox chkListStations;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlay;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelNowTime;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecordAudio;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboWaveInDevice;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private System.Windows.Forms.ComboBox comboWasapiDevices;
        private System.Windows.Forms.RadioButton radioButtonWaveIn;
        private System.Windows.Forms.ComboBox comboWasapiLoopbackDevices;
        private Bunifu.Framework.UI.BunifuFlatButton btnStopRecording;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Timer timerResponse;
    }
}