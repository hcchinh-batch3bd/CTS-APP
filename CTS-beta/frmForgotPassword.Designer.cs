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
            this.txtID = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(41, 130);
            this.txtID.Name = "txtID";
            this.txtID.NullText = "Email";
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
            this.txtPassword.Location = new System.Drawing.Point(41, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NullText = "Mã xác nhận";
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.ShowNullText = true;
            this.txtPassword.Size = new System.Drawing.Size(259, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.ThemeName = "Material";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radButton1.BackColor = System.Drawing.Color.PowderBlue;
            this.radButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.radButton1.Location = new System.Drawing.Point(102, 291);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(135, 36);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Gửi yêu cầu";
            this.radButton1.ThemeName = "Material";
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CTS_beta.Properties.Resources.abc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(339, 527);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmForgotPassword";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "QUÊN MẬT KHẨU";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadTextBox txtID;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}

