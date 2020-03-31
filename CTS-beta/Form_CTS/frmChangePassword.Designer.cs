namespace CTS_beta
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.txtPasswordOld = new Telerik.WinControls.UI.RadTextBox();
            this.txtPasswordNew = new Telerik.WinControls.UI.RadTextBox();
            this.txtPasswordNewComfirm = new Telerik.WinControls.UI.RadTextBox();
            this.btnChangePassword = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordNewComfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasswordOld
            // 
            this.txtPasswordOld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordOld.Location = new System.Drawing.Point(40, 196);
            this.txtPasswordOld.Name = "txtPasswordOld";
            this.txtPasswordOld.NullText = "Mật khẩu cũ";
            this.txtPasswordOld.PasswordChar = '●';
            this.txtPasswordOld.Size = new System.Drawing.Size(259, 36);
            this.txtPasswordOld.TabIndex = 0;
            this.txtPasswordOld.ThemeName = "Material";
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordNew.Location = new System.Drawing.Point(40, 253);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.NullText = "Mật khẩu mới";
            this.txtPasswordNew.PasswordChar = '●';
            this.txtPasswordNew.Size = new System.Drawing.Size(259, 36);
            this.txtPasswordNew.TabIndex = 1;
            this.txtPasswordNew.ThemeName = "Material";
            this.txtPasswordNew.UseSystemPasswordChar = true;
            // 
            // txtPasswordNewComfirm
            // 
            this.txtPasswordNewComfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordNewComfirm.BackColor = System.Drawing.Color.White;
            this.txtPasswordNewComfirm.Location = new System.Drawing.Point(40, 306);
            this.txtPasswordNewComfirm.Name = "txtPasswordNewComfirm";
            this.txtPasswordNewComfirm.NullText = "Nhập lại mật khẩu";
            this.txtPasswordNewComfirm.PasswordChar = '●';
            this.txtPasswordNewComfirm.Size = new System.Drawing.Size(259, 36);
            this.txtPasswordNewComfirm.TabIndex = 2;
            this.txtPasswordNewComfirm.ThemeName = "Material";
            this.txtPasswordNewComfirm.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(102, 383);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(135, 36);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Thay đổi";
            this.btnChangePassword.ThemeName = "Material";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CTS_beta.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(70, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CTS_beta.Properties.Resources.abc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(339, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtPasswordNewComfirm);
            this.Controls.Add(this.txtPasswordNew);
            this.Controls.Add(this.txtPasswordOld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangePassword";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmChangePassword_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordNewComfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadTextBox txtPasswordOld;
        private Telerik.WinControls.UI.RadTextBox txtPasswordNew;
        private Telerik.WinControls.UI.RadTextBox txtPasswordNewComfirm;
        private Telerik.WinControls.UI.RadButton btnChangePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
