namespace Digi_Com.AppForms
{
    partial class frmAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuth));
            this.pbFinger = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAccept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReject = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinger)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFinger
            // 
            this.pbFinger.Image = global::Digi_Com.Properties.Resources.scanner;
            this.pbFinger.Location = new System.Drawing.Point(-4, -3);
            this.pbFinger.Name = "pbFinger";
            this.pbFinger.Size = new System.Drawing.Size(147, 144);
            this.pbFinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFinger.TabIndex = 1;
            this.pbFinger.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Authenticate Yourself";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(158, 47);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(82, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Please wait.......";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccept
            // 
            this.btnAccept.Active = false;
            this.btnAccept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.BorderRadius = 0;
            this.btnAccept.ButtonText = "Accept Call";
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccept.Enabled = false;
            this.btnAccept.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccept.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccept.Iconimage")));
            this.btnAccept.Iconimage_right = null;
            this.btnAccept.Iconimage_right_Selected = null;
            this.btnAccept.Iconimage_Selected = null;
            this.btnAccept.IconMarginLeft = 0;
            this.btnAccept.IconMarginRight = 0;
            this.btnAccept.IconRightVisible = true;
            this.btnAccept.IconRightZoom = 0D;
            this.btnAccept.IconVisible = true;
            this.btnAccept.IconZoom = 90D;
            this.btnAccept.IsTab = false;
            this.btnAccept.Location = new System.Drawing.Point(161, 82);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccept.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccept.selected = false;
            this.btnAccept.Size = new System.Drawing.Size(147, 48);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept Call";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Textcolor = System.Drawing.Color.White;
            this.btnAccept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Active = false;
            this.btnReject.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReject.BorderRadius = 0;
            this.btnReject.ButtonText = "Reject Call";
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.DisabledColor = System.Drawing.Color.Gray;
            this.btnReject.Enabled = false;
            this.btnReject.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReject.Iconimage = global::Digi_Com.Properties.Resources.close;
            this.btnReject.Iconimage_right = null;
            this.btnReject.Iconimage_right_Selected = null;
            this.btnReject.Iconimage_Selected = null;
            this.btnReject.IconMarginLeft = 0;
            this.btnReject.IconMarginRight = 0;
            this.btnReject.IconRightVisible = true;
            this.btnReject.IconRightZoom = 0D;
            this.btnReject.IconVisible = true;
            this.btnReject.IconZoom = 50D;
            this.btnReject.IsTab = false;
            this.btnReject.Location = new System.Drawing.Point(314, 82);
            this.btnReject.Name = "btnReject";
            this.btnReject.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReject.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnReject.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReject.selected = false;
            this.btnReject.Size = new System.Drawing.Size(110, 48);
            this.btnReject.TabIndex = 5;
            this.btnReject.Text = "Reject Call";
            this.btnReject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReject.Textcolor = System.Drawing.Color.White;
            this.btnReject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // frmAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Digi_Com.Properties.Resources.backgroud1;
            this.ClientSize = new System.Drawing.Size(436, 142);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFinger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization Window";
            this.Load += new System.EventHandler(this.frmAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFinger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFinger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccept;
        private Bunifu.Framework.UI.BunifuFlatButton btnReject;
    }
}