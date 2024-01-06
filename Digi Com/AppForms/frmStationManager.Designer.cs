namespace Digi_Com.AppForms
{
    partial class frmStationManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStationManager));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvStations = new System.Windows.Forms.ListView();
            this.colStationID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStationCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.txtStationCode = new System.Windows.Forms.TextBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Station Manager";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(21, 72);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1233, 83);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvStations);
            this.groupBox2.Location = new System.Drawing.Point(70, 300);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(1153, 873);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Station List";
            // 
            // lvStations
            // 
            this.lvStations.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvStations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStationID,
            this.colStationName,
            this.colStationCode});
            this.lvStations.FullRowSelect = true;
            this.lvStations.GridLines = true;
            this.lvStations.HideSelection = false;
            this.lvStations.Location = new System.Drawing.Point(23, 38);
            this.lvStations.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lvStations.Name = "lvStations";
            this.lvStations.Size = new System.Drawing.Size(1106, 790);
            this.lvStations.TabIndex = 0;
            this.lvStations.UseCompatibleStateImageBehavior = false;
            this.lvStations.View = System.Windows.Forms.View.Details;
            this.lvStations.DoubleClick += new System.EventHandler(this.lvStations_DoubleClick);
            // 
            // colStationID
            // 
            this.colStationID.Text = "ID";
            this.colStationID.Width = 0;
            // 
            // colStationName
            // 
            this.colStationName.Text = "Station Name";
            this.colStationName.Width = 200;
            // 
            // colStationCode
            // 
            this.colStationCode.Text = "Station Code";
            this.colStationCode.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(588, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Station Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(87, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Station Name";
            // 
            // txtStationName
            // 
            this.txtStationName.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationName.ForeColor = System.Drawing.Color.White;
            this.txtStationName.Location = new System.Drawing.Point(76, 207);
            this.txtStationName.Multiline = true;
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(486, 83);
            this.txtStationName.TabIndex = 33;
            // 
            // txtStationCode
            // 
            this.txtStationCode.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtStationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationCode.ForeColor = System.Drawing.Color.White;
            this.txtStationCode.Location = new System.Drawing.Point(581, 207);
            this.txtStationCode.Multiline = true;
            this.txtStationCode.Name = "txtStationCode";
            this.txtStationCode.Size = new System.Drawing.Size(298, 83);
            this.txtStationCode.TabIndex = 34;
            // 
            // btnSave
            // 
            this.btnSave.Active = false;
            this.btnSave.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(901, 208);
            this.btnSave.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(269, 82);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // frmStationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1302, 1207);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStationCode);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmStationManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Station Manager";
            this.Load += new System.EventHandler(this.frmStationManager_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvStations;
        private System.Windows.Forms.ColumnHeader colStationID;
        private System.Windows.Forms.ColumnHeader colStationName;
        private System.Windows.Forms.ColumnHeader colStationCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStationCode;
        private System.Windows.Forms.TextBox txtStationName;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
    }
}