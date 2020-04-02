namespace CTS_beta.Form_CTS
{
    partial class frmCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAccount));
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.txtname_employee = new Telerik.WinControls.UI.RadTextBox();
            this.txtpassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtdate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlevel = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateAccount.Image = global::CTS_beta.Properties.Resources.add_new_32px;
            this.btnCreateAccount.Location = new System.Drawing.Point(158, 310);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(154, 47);
            this.btnCreateAccount.TabIndex = 36;
            this.btnCreateAccount.Text = "Tạo tài khoản";
            this.btnCreateAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(416, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 35);
            this.button13.TabIndex = 30;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 39);
            this.panel3.TabIndex = 43;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "TẠO TÀI KHOẢN";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radLabel2.Location = new System.Drawing.Point(53, 290);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(2, 2);
            this.radLabel2.TabIndex = 41;
            // 
            // txtname_employee
            // 
            this.txtname_employee.Location = new System.Drawing.Point(66, 76);
            this.txtname_employee.MaxLength = 50;
            this.txtname_employee.Name = "txtname_employee";
            this.txtname_employee.NullText = "Tên nhân viên";
            this.txtname_employee.Size = new System.Drawing.Size(333, 36);
            this.txtname_employee.TabIndex = 44;
            this.txtname_employee.ThemeName = "MaterialTeal";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(66, 128);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.NullText = "Mật khẩu";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.Size = new System.Drawing.Size(127, 36);
            this.txtpassword.TabIndex = 44;
            this.txtpassword.ThemeName = "MaterialTeal";
            // 
            // txtdate
            // 
            this.txtdate.CalendarSize = new System.Drawing.Size(290, 320);
            this.txtdate.Location = new System.Drawing.Point(144, 176);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(255, 36);
            this.txtdate.TabIndex = 45;
            this.txtdate.TabStop = false;
            this.txtdate.Text = "Monday, March 23, 2020";
            this.txtdate.ThemeName = "MaterialTeal";
            this.txtdate.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label1.Location = new System.Drawing.Point(66, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ngày sinh:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(66, 228);
            this.txtemail.Name = "txtemail";
            this.txtemail.NullText = "Email";
            this.txtemail.Size = new System.Drawing.Size(333, 36);
            this.txtemail.TabIndex = 48;
            this.txtemail.ThemeName = "MaterialTeal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(206, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Chức vụ:";
            // 
            // txtlevel
            // 
            this.txtlevel.FormattingEnabled = true;
            this.txtlevel.Location = new System.Drawing.Point(278, 130);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.Size = new System.Drawing.Size(121, 21);
            this.txtlevel.TabIndex = 1;
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 413);
            this.Controls.Add(this.txtlevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtname_employee);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.radLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateAccount";
            this.Load += new System.EventHandler(this.frmCreateAccount_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCreateAccount_MouseDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadTextBox txtname_employee;
        private Telerik.WinControls.UI.RadTextBox txtpassword;
        private Telerik.WinControls.UI.RadDateTimePicker txtdate;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtlevel;
    }
}