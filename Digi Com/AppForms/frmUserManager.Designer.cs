namespace Digi_Com.AppForms
{
    partial class frmUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManager));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArmyNo = new System.Windows.Forms.TextBox();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.cmbPrefix = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancleUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.colPersonelID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArmyNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMobileNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRankID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrefixID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFingreID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArmyNoOnly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEnrollFingre = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Manager";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(21, 72);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(2221, 83);
            this.bunifuSeparator1.TabIndex = 8;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMobileNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtArmyNo);
            this.groupBox1.Controls.Add(this.cmbRank);
            this.groupBox1.Controls.Add(this.cmbPrefix);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCancleUser);
            this.groupBox1.Controls.Add(this.btnSaveUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(541, 553);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mobile No";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(16, 274);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(503, 38);
            this.txtMobileNo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Army No";
            // 
            // txtArmyNo
            // 
            this.txtArmyNo.Location = new System.Drawing.Point(344, 74);
            this.txtArmyNo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtArmyNo.Name = "txtArmyNo";
            this.txtArmyNo.Size = new System.Drawing.Size(175, 38);
            this.txtArmyNo.TabIndex = 1;
            // 
            // cmbRank
            // 
            this.cmbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Location = new System.Drawing.Point(176, 74);
            this.cmbRank.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(145, 39);
            this.cmbRank.TabIndex = 13;
            // 
            // cmbPrefix
            // 
            this.cmbPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrefix.FormattingEnabled = true;
            this.cmbPrefix.Location = new System.Drawing.Point(16, 74);
            this.cmbPrefix.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbPrefix.Name = "cmbPrefix";
            this.cmbPrefix.Size = new System.Drawing.Size(137, 39);
            this.cmbPrefix.TabIndex = 12;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(16, 374);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(503, 39);
            this.cmbRole.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "User Role";
            // 
            // btnCancleUser
            // 
            this.btnCancleUser.Active = false;
            this.btnCancleUser.Activecolor = System.Drawing.Color.Transparent;
            this.btnCancleUser.BackColor = System.Drawing.Color.Transparent;
            this.btnCancleUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancleUser.BorderRadius = 0;
            this.btnCancleUser.ButtonText = "";
            this.btnCancleUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancleUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancleUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancleUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancleUser.Iconimage")));
            this.btnCancleUser.Iconimage_right = null;
            this.btnCancleUser.Iconimage_right_Selected = null;
            this.btnCancleUser.Iconimage_Selected = null;
            this.btnCancleUser.IconMarginLeft = 0;
            this.btnCancleUser.IconMarginRight = 0;
            this.btnCancleUser.IconRightVisible = true;
            this.btnCancleUser.IconRightZoom = 0D;
            this.btnCancleUser.IconVisible = true;
            this.btnCancleUser.IconZoom = 90D;
            this.btnCancleUser.IsTab = false;
            this.btnCancleUser.Location = new System.Drawing.Point(16, 455);
            this.btnCancleUser.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnCancleUser.Name = "btnCancleUser";
            this.btnCancleUser.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCancleUser.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCancleUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancleUser.selected = false;
            this.btnCancleUser.Size = new System.Drawing.Size(93, 83);
            this.btnCancleUser.TabIndex = 8;
            this.btnCancleUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancleUser.Textcolor = System.Drawing.Color.White;
            this.btnCancleUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleUser.Click += new System.EventHandler(this.btnCancleUser_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Active = false;
            this.btnSaveUser.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnSaveUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSaveUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveUser.BorderRadius = 0;
            this.btnSaveUser.ButtonText = "Save";
            this.btnSaveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.Iconimage")));
            this.btnSaveUser.Iconimage_right = null;
            this.btnSaveUser.Iconimage_right_Selected = null;
            this.btnSaveUser.Iconimage_Selected = null;
            this.btnSaveUser.IconMarginLeft = 0;
            this.btnSaveUser.IconMarginRight = 0;
            this.btnSaveUser.IconRightVisible = true;
            this.btnSaveUser.IconRightZoom = 0D;
            this.btnSaveUser.IconVisible = true;
            this.btnSaveUser.IconZoom = 90D;
            this.btnSaveUser.IsTab = false;
            this.btnSaveUser.Location = new System.Drawing.Point(125, 455);
            this.btnSaveUser.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnSaveUser.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.btnSaveUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveUser.selected = false;
            this.btnSaveUser.Size = new System.Drawing.Size(334, 83);
            this.btnSaveUser.TabIndex = 7;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUser.Textcolor = System.Drawing.Color.White;
            this.btnSaveUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 172);
            this.txtName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(503, 38);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prefix";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvUsers);
            this.groupBox2.Location = new System.Drawing.Point(589, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(1653, 782);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User List";
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPersonelID,
            this.colArmyNo,
            this.colRank,
            this.colName,
            this.colMobileNo,
            this.colRoleName,
            this.colLastLogin,
            this.colRankID,
            this.colPrefixID,
            this.colFingreID,
            this.colRoleID,
            this.colArmyNoOnly});
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.GridLines = true;
            this.lvUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(16, 45);
            this.lvUsers.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(1590, 723);
            this.lvUsers.TabIndex = 0;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            this.lvUsers.DoubleClick += new System.EventHandler(this.lvUsers_DoubleClick);
            this.lvUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvUsers_KeyDown);
            // 
            // colPersonelID
            // 
            this.colPersonelID.Text = "ID";
            this.colPersonelID.Width = 0;
            // 
            // colArmyNo
            // 
            this.colArmyNo.Text = "Army No";
            this.colArmyNo.Width = 80;
            // 
            // colRank
            // 
            this.colRank.Text = "Rank";
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 160;
            // 
            // colMobileNo
            // 
            this.colMobileNo.Text = "Mobile No";
            this.colMobileNo.Width = 100;
            // 
            // colRoleName
            // 
            this.colRoleName.Text = "Role";
            this.colRoleName.Width = 70;
            // 
            // colLastLogin
            // 
            this.colLastLogin.Text = "Last Login";
            this.colLastLogin.Width = 120;
            // 
            // colRankID
            // 
            this.colRankID.Text = "Rank ID";
            this.colRankID.Width = 0;
            // 
            // colPrefixID
            // 
            this.colPrefixID.Text = "Prefix ID";
            this.colPrefixID.Width = 0;
            // 
            // colFingreID
            // 
            this.colFingreID.Text = "Fingre ID";
            this.colFingreID.Width = 0;
            // 
            // colRoleID
            // 
            this.colRoleID.Text = "RoleID";
            this.colRoleID.Width = 0;
            // 
            // colArmyNoOnly
            // 
            this.colArmyNoOnly.Text = "ArmyNo";
            this.colArmyNoOnly.Width = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnEnrollFingre);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(35, 775);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Size = new System.Drawing.Size(541, 162);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Biometric Data";
            // 
            // btnEnrollFingre
            // 
            this.btnEnrollFingre.Active = false;
            this.btnEnrollFingre.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnEnrollFingre.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEnrollFingre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnrollFingre.BorderRadius = 0;
            this.btnEnrollFingre.ButtonText = "Enroll Fingreprint";
            this.btnEnrollFingre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnrollFingre.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnrollFingre.Enabled = false;
            this.btnEnrollFingre.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnrollFingre.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEnrollFingre.Iconimage")));
            this.btnEnrollFingre.Iconimage_right = null;
            this.btnEnrollFingre.Iconimage_right_Selected = null;
            this.btnEnrollFingre.Iconimage_Selected = null;
            this.btnEnrollFingre.IconMarginLeft = 0;
            this.btnEnrollFingre.IconMarginRight = 0;
            this.btnEnrollFingre.IconRightVisible = true;
            this.btnEnrollFingre.IconRightZoom = 0D;
            this.btnEnrollFingre.IconVisible = true;
            this.btnEnrollFingre.IconZoom = 90D;
            this.btnEnrollFingre.IsTab = false;
            this.btnEnrollFingre.Location = new System.Drawing.Point(13, 45);
            this.btnEnrollFingre.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnEnrollFingre.Name = "btnEnrollFingre";
            this.btnEnrollFingre.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnEnrollFingre.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.btnEnrollFingre.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnrollFingre.selected = false;
            this.btnEnrollFingre.Size = new System.Drawing.Size(509, 98);
            this.btnEnrollFingre.TabIndex = 10;
            this.btnEnrollFingre.Text = "Enroll Fingreprint";
            this.btnEnrollFingre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnrollFingre.Textcolor = System.Drawing.Color.White;
            this.btnEnrollFingre.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollFingre.Click += new System.EventHandler(this.btnEnrollFingre_Click);
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2275, 980);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmUserManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Manager";
            this.Load += new System.EventHandler(this.frmUserManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader colArmyNo;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colRank;
        private System.Windows.Forms.ColumnHeader colLastLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnrollFingre;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArmyNo;
        private System.Windows.Forms.ComboBox cmbRank;
        private System.Windows.Forms.ComboBox cmbPrefix;
        private System.Windows.Forms.ColumnHeader colRankID;
        private System.Windows.Forms.ColumnHeader colPrefixID;
        private System.Windows.Forms.ColumnHeader colFingreID;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancleUser;
        private System.Windows.Forms.ColumnHeader colPersonelID;
        private System.Windows.Forms.ColumnHeader colRoleID;
        private System.Windows.Forms.ColumnHeader colArmyNoOnly;
        private System.Windows.Forms.ColumnHeader colRoleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.ColumnHeader colMobileNo;
    }
}