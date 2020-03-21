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
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox3 = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radTextBox1.Location = new System.Drawing.Point(67, 113);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "Mật khẩu cũ:";
            this.radTextBox1.Size = new System.Drawing.Size(240, 36);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.ThemeName = "Material";
            // 
            // radTextBox2
            // 
            this.radTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radTextBox2.Location = new System.Drawing.Point(67, 170);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.NullText = "Mật khẩu mới:";
            this.radTextBox2.PasswordChar = '●';
            this.radTextBox2.Size = new System.Drawing.Size(240, 36);
            this.radTextBox2.TabIndex = 1;
            this.radTextBox2.ThemeName = "Material";
            this.radTextBox2.UseSystemPasswordChar = true;
            // 
            // radTextBox3
            // 
            this.radTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radTextBox3.BackColor = System.Drawing.Color.White;
            this.radTextBox3.Location = new System.Drawing.Point(67, 223);
            this.radTextBox3.Name = "radTextBox3";
            this.radTextBox3.NullText = "Nhập lại mật khẩu:";
            this.radTextBox3.PasswordChar = '●';
            this.radTextBox3.Size = new System.Drawing.Size(240, 36);
            this.radTextBox3.TabIndex = 2;
            this.radTextBox3.ThemeName = "Material";
            this.radTextBox3.UseSystemPasswordChar = true;
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radButton1.BackColor = System.Drawing.Color.PowderBlue;
            this.radButton1.Location = new System.Drawing.Point(67, 307);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(240, 36);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Thay đổi";
            this.radButton1.ThemeName = "Material";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CTS_beta.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(81, 7);
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
            this.ClientSize = new System.Drawing.Size(374, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radTextBox3);
            this.Controls.Add(this.radTextBox2);
            this.Controls.Add(this.radTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangePassword";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ĐỔI MẬT KHẨU";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadTextBox radTextBox3;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
