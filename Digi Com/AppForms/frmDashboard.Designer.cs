namespace Digi_Com.AppForms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.dashboardDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTopbar = new System.Windows.Forms.Panel();
            this.btnMin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblTotalStation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lblTodayFreq = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.colSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMessages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlayMessage = new System.Windows.Forms.Button();
            this.btnScheduleManager = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStationManager = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUserManager = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMakeCall = new Bunifu.Framework.UI.BunifuTileButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLastLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmCallerName = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblTrMessage = new System.Windows.Forms.Label();
            this.panelTopbar.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardDragControl
            // 
            this.dashboardDragControl.Fixed = true;
            this.dashboardDragControl.Horizontal = true;
            this.dashboardDragControl.TargetControl = this.panelTopbar;
            this.dashboardDragControl.Vertical = true;
            // 
            // panelTopbar
            // 
            this.panelTopbar.BackColor = System.Drawing.Color.PowderBlue;
            this.panelTopbar.Controls.Add(this.btnMin);
            this.panelTopbar.Controls.Add(this.label1);
            this.panelTopbar.Controls.Add(this.lblUsername);
            this.panelTopbar.Controls.Add(this.bunifuSwitch1);
            this.panelTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopbar.Location = new System.Drawing.Point(0, 0);
            this.panelTopbar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelTopbar.Name = "panelTopbar";
            this.panelTopbar.Size = new System.Drawing.Size(2693, 107);
            this.panelTopbar.TabIndex = 3;
            this.panelTopbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTopbar_Paint);
            // 
            // btnMin
            // 
            this.btnMin.Active = false;
            this.btnMin.Activecolor = System.Drawing.Color.Transparent;
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.BorderRadius = 0;
            this.btnMin.ButtonText = "";
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.DisabledColor = System.Drawing.Color.Gray;
            this.btnMin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMin.Iconimage")));
            this.btnMin.Iconimage_right = null;
            this.btnMin.Iconimage_right_Selected = null;
            this.btnMin.Iconimage_Selected = null;
            this.btnMin.IconMarginLeft = 0;
            this.btnMin.IconMarginRight = 0;
            this.btnMin.IconRightVisible = true;
            this.btnMin.IconRightZoom = 0D;
            this.btnMin.IconVisible = true;
            this.btnMin.IconZoom = 50D;
            this.btnMin.IsTab = false;
            this.btnMin.Location = new System.Drawing.Point(2584, 12);
            this.btnMin.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnMin.Name = "btnMin";
            this.btnMin.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMin.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnMin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMin.selected = false;
            this.btnMin.Size = new System.Drawing.Size(91, 67);
            this.btnMin.TabIndex = 19;
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMin.Textcolor = System.Drawing.Color.White;
            this.btnMin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(2197, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Receive Mode";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUsername.Location = new System.Drawing.Point(24, 31);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(347, 46);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Welcome {User} !";
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.White;
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Location = new System.Drawing.Point(2419, 29);
            this.bunifuSwitch1.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.LimeGreen;
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.Red;
            this.bunifuSwitch1.Size = new System.Drawing.Size(0, 0);
            this.bunifuSwitch1.TabIndex = 5;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.Gray;
            this.bunifuSwitch1.Value = true;
            this.bunifuSwitch1.Click += new System.EventHandler(this.bunifuSwitch1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.lblTotalStation);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(992, 129);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(371, 346);
            this.bunifuCards1.TabIndex = 5;
            // 
            // lblTotalStation
            // 
            this.lblTotalStation.AutoSize = true;
            this.lblTotalStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalStation.Location = new System.Drawing.Point(115, 134);
            this.lblTotalStation.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotalStation.Name = "lblTotalStation";
            this.lblTotalStation.Size = new System.Drawing.Size(92, 101);
            this.lblTotalStation.TabIndex = 8;
            this.lblTotalStation.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Station";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Green;
            this.bunifuCards2.Controls.Add(this.lblTodayFreq);
            this.bunifuCards2.Controls.Add(this.label5);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(1379, 129);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(411, 346);
            this.bunifuCards2.TabIndex = 6;
            // 
            // lblTodayFreq
            // 
            this.lblTodayFreq.AutoSize = true;
            this.lblTodayFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayFreq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTodayFreq.Location = new System.Drawing.Point(85, 134);
            this.lblTodayFreq.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTodayFreq.Name = "lblTodayFreq";
            this.lblTodayFreq.Size = new System.Drawing.Size(214, 101);
            this.lblTodayFreq.TabIndex = 10;
            this.lblTodayFreq.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(19, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Today\'s Frequency (MHz)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtToDate);
            this.groupBox1.Controls.Add(this.dtFromDate);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.lvLogs);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(557, 489);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(2104, 618);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Call Log";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1427, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "To Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(941, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "From Date";
            // 
            // dtToDate
            // 
            this.dtToDate.CustomFormat = "yyyy-MM-dd";
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDate.Location = new System.Drawing.Point(1565, 45);
            this.dtToDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(287, 38);
            this.dtToDate.TabIndex = 12;
            // 
            // dtFromDate
            // 
            this.dtFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromDate.Location = new System.Drawing.Point(1107, 45);
            this.dtFromDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(289, 38);
            this.dtFromDate.TabIndex = 11;
            // 
            // btnExport
            // 
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(1888, 43);
            this.btnExport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(200, 55);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lvLogs
            // 
            this.lvLogs.BackColor = System.Drawing.Color.White;
            this.lvLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSerial,
            this.colDate,
            this.colMessages});
            this.lvLogs.GridLines = true;
            this.lvLogs.HideSelection = false;
            this.lvLogs.Location = new System.Drawing.Point(16, 117);
            this.lvLogs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(2072, 486);
            this.lvLogs.TabIndex = 9;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // colSerial
            // 
            this.colSerial.Text = "Serial";
            // 
            // colDate
            // 
            this.colDate.Text = "Date & Time";
            this.colDate.Width = 200;
            // 
            // colMessages
            // 
            this.colMessages.Text = "Messages";
            this.colMessages.Width = 500;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Digi_Com.Properties.Resources.Login1;
            this.panel1.Controls.Add(this.btnPlayMessage);
            this.panel1.Controls.Add(this.btnScheduleManager);
            this.panel1.Controls.Add(this.btnStationManager);
            this.panel1.Controls.Add(this.btnUserManager);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 1059);
            this.panel1.TabIndex = 7;
            // 
            // btnPlayMessage
            // 
            this.btnPlayMessage.Enabled = false;
            this.btnPlayMessage.Location = new System.Drawing.Point(35, 622);
            this.btnPlayMessage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPlayMessage.Name = "btnPlayMessage";
            this.btnPlayMessage.Size = new System.Drawing.Size(459, 93);
            this.btnPlayMessage.TabIndex = 11;
            this.btnPlayMessage.Text = "Play Last Received Message";
            this.btnPlayMessage.UseVisualStyleBackColor = true;
            this.btnPlayMessage.Click += new System.EventHandler(this.btnPlayMessage_Click);
            // 
            // btnScheduleManager
            // 
            this.btnScheduleManager.Active = false;
            this.btnScheduleManager.Activecolor = System.Drawing.Color.Transparent;
            this.btnScheduleManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScheduleManager.BackColor = System.Drawing.Color.Transparent;
            this.btnScheduleManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScheduleManager.BorderRadius = 0;
            this.btnScheduleManager.ButtonText = "Schedule Manager";
            this.btnScheduleManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScheduleManager.DisabledColor = System.Drawing.Color.Gray;
            this.btnScheduleManager.Iconcolor = System.Drawing.Color.Transparent;
            this.btnScheduleManager.Iconimage = global::Digi_Com.Properties.Resources.schedule;
            this.btnScheduleManager.Iconimage_right = null;
            this.btnScheduleManager.Iconimage_right_Selected = null;
            this.btnScheduleManager.Iconimage_Selected = null;
            this.btnScheduleManager.IconMarginLeft = 0;
            this.btnScheduleManager.IconMarginRight = 0;
            this.btnScheduleManager.IconRightVisible = true;
            this.btnScheduleManager.IconRightZoom = 0D;
            this.btnScheduleManager.IconVisible = true;
            this.btnScheduleManager.IconZoom = 60D;
            this.btnScheduleManager.IsTab = false;
            this.btnScheduleManager.Location = new System.Drawing.Point(0, 181);
            this.btnScheduleManager.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnScheduleManager.Name = "btnScheduleManager";
            this.btnScheduleManager.Normalcolor = System.Drawing.Color.Transparent;
            this.btnScheduleManager.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnScheduleManager.OnHoverTextColor = System.Drawing.Color.White;
            this.btnScheduleManager.selected = false;
            this.btnScheduleManager.Size = new System.Drawing.Size(533, 114);
            this.btnScheduleManager.TabIndex = 1;
            this.btnScheduleManager.Text = "Schedule Manager";
            this.btnScheduleManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleManager.Textcolor = System.Drawing.Color.White;
            this.btnScheduleManager.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleManager.Click += new System.EventHandler(this.btnScheduleManager_Click);
            // 
            // btnStationManager
            // 
            this.btnStationManager.Active = false;
            this.btnStationManager.Activecolor = System.Drawing.Color.Transparent;
            this.btnStationManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStationManager.BackColor = System.Drawing.Color.Transparent;
            this.btnStationManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStationManager.BorderRadius = 0;
            this.btnStationManager.ButtonText = "Station Manager";
            this.btnStationManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStationManager.DisabledColor = System.Drawing.Color.Gray;
            this.btnStationManager.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStationManager.Iconimage = global::Digi_Com.Properties.Resources.station;
            this.btnStationManager.Iconimage_right = null;
            this.btnStationManager.Iconimage_right_Selected = null;
            this.btnStationManager.Iconimage_Selected = null;
            this.btnStationManager.IconMarginLeft = 0;
            this.btnStationManager.IconMarginRight = 0;
            this.btnStationManager.IconRightVisible = true;
            this.btnStationManager.IconRightZoom = 0D;
            this.btnStationManager.IconVisible = true;
            this.btnStationManager.IconZoom = 60D;
            this.btnStationManager.IsTab = false;
            this.btnStationManager.Location = new System.Drawing.Point(0, 305);
            this.btnStationManager.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnStationManager.Name = "btnStationManager";
            this.btnStationManager.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStationManager.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnStationManager.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStationManager.selected = false;
            this.btnStationManager.Size = new System.Drawing.Size(533, 114);
            this.btnStationManager.TabIndex = 2;
            this.btnStationManager.Text = "Station Manager";
            this.btnStationManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStationManager.Textcolor = System.Drawing.Color.White;
            this.btnStationManager.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStationManager.Click += new System.EventHandler(this.btnStationManager_Click);
            // 
            // btnUserManager
            // 
            this.btnUserManager.Active = false;
            this.btnUserManager.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUserManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserManager.BackColor = System.Drawing.Color.Transparent;
            this.btnUserManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserManager.BorderRadius = 0;
            this.btnUserManager.ButtonText = "User Manager";
            this.btnUserManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManager.DisabledColor = System.Drawing.Color.Gray;
            this.btnUserManager.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUserManager.Iconimage = global::Digi_Com.Properties.Resources.users;
            this.btnUserManager.Iconimage_right = null;
            this.btnUserManager.Iconimage_right_Selected = null;
            this.btnUserManager.Iconimage_Selected = null;
            this.btnUserManager.IconMarginLeft = 0;
            this.btnUserManager.IconMarginRight = 0;
            this.btnUserManager.IconRightVisible = true;
            this.btnUserManager.IconRightZoom = 0D;
            this.btnUserManager.IconVisible = true;
            this.btnUserManager.IconZoom = 60D;
            this.btnUserManager.IsTab = false;
            this.btnUserManager.Location = new System.Drawing.Point(0, 424);
            this.btnUserManager.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUserManager.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnUserManager.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUserManager.selected = false;
            this.btnUserManager.Size = new System.Drawing.Size(533, 114);
            this.btnUserManager.TabIndex = 3;
            this.btnUserManager.Text = "User Manager";
            this.btnUserManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManager.Textcolor = System.Drawing.Color.White;
            this.btnUserManager.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(131, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 76);
            this.label6.TabIndex = 8;
            this.label6.Text = "DIGI COM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Digi_Com.Properties.Resources.radio;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 157);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Change Password";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 756);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(533, 114);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "Change Password";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Visible = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Active = false;
            this.btnLogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "Log Out";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Iconimage")));
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 0;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 90D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(0, 851);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(533, 114);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Textcolor = System.Drawing.Color.White;
            this.btnLogOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMakeCall
            // 
            this.btnMakeCall.BackColor = System.Drawing.Color.Green;
            this.btnMakeCall.color = System.Drawing.Color.Green;
            this.btnMakeCall.colorActive = System.Drawing.Color.DarkGreen;
            this.btnMakeCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeCall.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMakeCall.ForeColor = System.Drawing.Color.White;
            this.btnMakeCall.Image = global::Digi_Com.Properties.Resources.call1;
            this.btnMakeCall.ImagePosition = 20;
            this.btnMakeCall.ImageZoom = 50;
            this.btnMakeCall.LabelPosition = 41;
            this.btnMakeCall.LabelText = "Make A Call";
            this.btnMakeCall.Location = new System.Drawing.Point(557, 129);
            this.btnMakeCall.Margin = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(411, 334);
            this.btnMakeCall.TabIndex = 4;
            this.btnMakeCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblLastLogin});
            this.statusStrip1.Location = new System.Drawing.Point(533, 1120);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 37, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(2160, 46);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(175, 41);
            this.toolStripStatusLabel1.Text = "Last Login : ";
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.ForeColor = System.Drawing.Color.Green;
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(190, 41);
            this.lblLastLogin.Text = "Not available";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1805, 129);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(856, 346);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(173)))), ((int)(((byte)(52)))));
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(1883, 231);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(709, 141);
            this.txtDisplay.TabIndex = 12;
            // 
            // lblTrMessage
            // 
            this.lblTrMessage.AutoSize = true;
            this.lblTrMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(173)))), ((int)(((byte)(52)))));
            this.lblTrMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrMessage.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTrMessage.Location = new System.Drawing.Point(1893, 253);
            this.lblTrMessage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTrMessage.Name = "lblTrMessage";
            this.lblTrMessage.Size = new System.Drawing.Size(601, 95);
            this.lblTrMessage.TabIndex = 15;
            this.lblTrMessage.Text = "System Offline";
            this.lblTrMessage.Visible = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Digi_Com.Properties.Resources.backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2693, 1166);
            this.Controls.Add(this.lblTrMessage);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.btnMakeCall);
            this.Controls.Add(this.panelTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.Activated += new System.EventHandler(this.frmDashboard_Activated);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panelTopbar.ResumeLayout(false);
            this.panelTopbar.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl dashboardDragControl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelTopbar;
        private System.Windows.Forms.Label lblUsername;
        private Bunifu.Framework.UI.BunifuTileButton btnMakeCall;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lblTodayFreq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ColumnHeader colSerial;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colMessages;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnUserManager;
        private Bunifu.Framework.UI.BunifuFlatButton btnStationManager;
        private Bunifu.Framework.UI.BunifuFlatButton btnScheduleManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLastLogin;
        private System.Windows.Forms.Timer tmCallerName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtDisplay;
        private Bunifu.Framework.UI.BunifuFlatButton btnMin;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTrMessage;
        private System.Windows.Forms.Button btnPlayMessage;
    }
}