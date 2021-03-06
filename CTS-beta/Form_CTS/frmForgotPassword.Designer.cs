﻿namespace CTS_beta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtOTP = new Telerik.WinControls.UI.RadTextBox();
            this.btnChangePass = new Telerik.WinControls.UI.RadButton();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtPasswordComfirm = new Telerik.WinControls.UI.RadTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.dotsLineWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordComfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(36, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.NullText = "Email";
            this.txtEmail.ShowClearButton = true;
            this.txtEmail.ShowNullText = true;
            this.txtEmail.Size = new System.Drawing.Size(211, 36);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.ThemeName = "Material";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtOTP
            // 
            this.txtOTP.AcceptsReturn = true;
            this.txtOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOTP.ForeColor = System.Drawing.Color.Black;
            this.txtOTP.Location = new System.Drawing.Point(36, 257);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.NullText = "Mã xác nhận";
            this.txtOTP.ShowClearButton = true;
            this.txtOTP.ShowNullText = true;
            this.txtOTP.Size = new System.Drawing.Size(259, 36);
            this.txtOTP.TabIndex = 1;
            this.txtOTP.ThemeName = "Material";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePass.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(102, 420);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(135, 36);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "Gửi yêu cầu";
            this.btnChangePass.ThemeName = "Material";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(36, 317);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NullText = "Mật khẩu mới";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.ShowNullText = true;
            this.txtPassword.Size = new System.Drawing.Size(259, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.ThemeName = "Material";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CTS_beta.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(63, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSendCode
            // 
            this.btnSendCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendCode.FlatAppearance.BorderSize = 0;
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCode.Image = global::CTS_beta.Properties.Resources.mail;
            this.btnSendCode.Location = new System.Drawing.Point(253, 193);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(42, 36);
            this.btnSendCode.TabIndex = 5;
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPasswordComfirm
            // 
            this.txtPasswordComfirm.AcceptsReturn = true;
            this.txtPasswordComfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordComfirm.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordComfirm.Location = new System.Drawing.Point(36, 378);
            this.txtPasswordComfirm.Name = "txtPasswordComfirm";
            this.txtPasswordComfirm.NullText = "Xác nhận mật khẩu";
            this.txtPasswordComfirm.PasswordChar = '●';
            this.txtPasswordComfirm.ShowClearButton = true;
            this.txtPasswordComfirm.ShowNullText = true;
            this.txtPasswordComfirm.Size = new System.Drawing.Size(259, 36);
            this.txtPasswordComfirm.TabIndex = 3;
            this.txtPasswordComfirm.ThemeName = "Material";
            this.txtPasswordComfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordComfirm_KeyDown);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(107, 161);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(130, 24);
            this.radWaitingBar1.TabIndex = 1;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.WaitingIndicators.Add(this.dotsLineWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingSpeed = 80;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsLine;
            // 
            // dotsLineWaitingBarIndicatorElement1
            // 
            this.dotsLineWaitingBarIndicatorElement1.Name = "dotsLineWaitingBarIndicatorElement1";
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CTS_beta.Properties.Resources.abc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(339, 527);
            this.Controls.Add(this.radWaitingBar1);
            this.Controls.Add(this.txtPasswordComfirm);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.pictureBox1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUÊN MẬT KHẨU";
            this.ThemeName = "Material";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmForgotPassword_FormClosed);
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmForgotPassword_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordComfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadTextBox txtOTP;
        private Telerik.WinControls.UI.RadButton btnChangePass;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadTextBox txtPasswordComfirm;
        private System.Windows.Forms.Timer timer2;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement dotsLineWaitingBarIndicatorElement1;
    }
}

