namespace CTS_beta
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtID = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.ckbRemember = new Telerik.WinControls.UI.RadCheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.dotsLineWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbRemember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(39, 194);
            this.txtID.MaxLength = 6;
            this.txtID.Name = "txtID";
            this.txtID.NullText = "Mã đăng nhập";
            this.txtID.ShowClearButton = true;
            this.txtID.ShowNullText = true;
            this.txtID.Size = new System.Drawing.Size(259, 36);
            this.txtID.TabIndex = 0;
            this.txtID.ThemeName = "Material";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(39, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NullText = "Mật khẩu";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.ShowNullText = true;
            this.txtPassword.Size = new System.Drawing.Size(259, 36);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.ThemeName = "Material";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // ckbRemember
            // 
            this.ckbRemember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbRemember.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ckbRemember.Location = new System.Drawing.Point(105, 320);
            this.ckbRemember.Name = "ckbRemember";
            this.ckbRemember.Size = new System.Drawing.Size(118, 18);
            this.ckbRemember.TabIndex = 2;
            this.ckbRemember.Tag = "";
            this.ckbRemember.Text = "Ghi nhớ mật khẩu ?";
            this.ckbRemember.CheckStateChanged += new System.EventHandler(this.ckbRemember_CheckStateChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.linkLabel1.ForeColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(226, 503);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CTS_beta.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(75, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(92)))), ((int)(((byte)(250)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::CTS_beta.Properties.Resources.login_32px;
            this.btnLogin.Location = new System.Drawing.Point(163, 355);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.ThemeName = "Material";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(117, 164);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(130, 24);
            this.radWaitingBar1.TabIndex = 5;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.WaitingIndicators.Add(this.dotsLineWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingSpeed = 80;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsLine;
            // 
            // dotsLineWaitingBarIndicatorElement1
            // 
            this.dotsLineWaitingBarIndicatorElement1.Name = "dotsLineWaitingBarIndicatorElement1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CTS_beta.Properties.Resources.abc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 523);
            this.Controls.Add(this.radWaitingBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ckbRemember);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ThemeName = "Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbRemember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadTextBox txtID;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private Telerik.WinControls.UI.RadCheckBox ckbRemember;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement dotsLineWaitingBarIndicatorElement1;
    }
}