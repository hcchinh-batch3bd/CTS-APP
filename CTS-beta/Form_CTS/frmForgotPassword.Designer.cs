namespace CTS_beta
{
    partial class frmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtOTP = new Telerik.WinControls.UI.RadTextBox();
            this.btnChangePass = new Telerik.WinControls.UI.RadButton();
            this.btnSendCode = new Telerik.WinControls.UI.RadButton();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(16, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.NullText = "Email";
            this.txtEmail.ShowClearButton = true;
            this.txtEmail.ShowNullText = true;
            this.txtEmail.Size = new System.Drawing.Size(217, 36);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.ThemeName = "Material";
            // 
            // txtOTP
            // 
            this.txtOTP.AcceptsReturn = true;
            this.txtOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOTP.ForeColor = System.Drawing.Color.Black;
            this.txtOTP.Location = new System.Drawing.Point(16, 257);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.NullText = "Mã xác nhận";
            this.txtOTP.ShowClearButton = true;
            this.txtOTP.ShowNullText = true;
            this.txtOTP.Size = new System.Drawing.Size(304, 36);
            this.txtOTP.TabIndex = 2;
            this.txtOTP.ThemeName = "Material";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePass.BackColor = System.Drawing.Color.PowderBlue;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnChangePass.Location = new System.Drawing.Point(104, 388);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(135, 36);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "Gửi yêu cầu";
            this.btnChangePass.ThemeName = "Material";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnSendCode
            // 
            this.btnSendCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendCode.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSendCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSendCode.Location = new System.Drawing.Point(240, 193);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(81, 36);
            this.btnSendCode.TabIndex = 3;
            this.btnSendCode.Text = "Gửi";
            this.btnSendCode.ThemeName = "Material";
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(16, 317);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NullText = "Mật khẩu mới";
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.ShowNullText = true;
            this.txtPassword.Size = new System.Drawing.Size(304, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.ThemeName = "Material";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CTS_beta.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(70, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CTS_beta.Properties.Resources.abc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.txtEmail);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmForgotPassword";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "QUÊN MẬT KHẨU";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadTextBox txtOTP;
        private Telerik.WinControls.UI.RadButton btnChangePass;
        private Telerik.WinControls.UI.RadButton btnSendCode;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

