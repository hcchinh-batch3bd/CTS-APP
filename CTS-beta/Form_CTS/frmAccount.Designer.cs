namespace CTS_beta.Form_CTS
{
    partial class frmAccount
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.GridViewAccount = new Telerik.WinControls.UI.RadGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PicSyn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAccount.MasterTemplate)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSyn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewAccount
            // 
            this.GridViewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GridViewAccount.Location = new System.Drawing.Point(0, 42);
            // 
            // 
            // 
            this.GridViewAccount.MasterTemplate.AllowColumnReorder = false;
            this.GridViewAccount.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 78;
            gridViewTextBoxColumn2.HeaderText = "Họ và tên";
            gridViewTextBoxColumn2.Name = "name";
            gridViewTextBoxColumn2.Width = 249;
            gridViewTextBoxColumn3.HeaderText = "Tuổi";
            gridViewTextBoxColumn3.Name = "column1";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 75;
            gridViewTextBoxColumn4.HeaderText = "Email";
            gridViewTextBoxColumn4.Name = "column5";
            gridViewTextBoxColumn4.Width = 216;
            gridViewTextBoxColumn5.HeaderText = "Điểm";
            gridViewTextBoxColumn5.Name = "column2";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 82;
            gridViewTextBoxColumn6.HeaderText = "Quyền hạn";
            gridViewTextBoxColumn6.Name = "column4";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 118;
            gridViewTextBoxColumn7.HeaderText = "Trạng Thái";
            gridViewTextBoxColumn7.Name = "status";
            gridViewTextBoxColumn7.Width = 107;
            this.GridViewAccount.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.GridViewAccount.MasterTemplate.ShowHeaderCellButtons = true;
            this.GridViewAccount.MasterTemplate.ShowRowHeaderColumn = false;
            this.GridViewAccount.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.GridViewAccount.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GridViewAccount.Name = "GridViewAccount";
            this.GridViewAccount.ReadOnly = true;
            // 
            // 
            // 
            this.GridViewAccount.RootElement.AutoSize = false;
            this.GridViewAccount.ShowHeaderCellButtons = true;
            this.GridViewAccount.Size = new System.Drawing.Size(942, 531);
            this.GridViewAccount.TabIndex = 8;
            this.GridViewAccount.ThemeName = "MaterialTeal";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.PicSyn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 42);
            this.panel3.TabIndex = 9;
            // 
            // PicSyn
            // 
            this.PicSyn.Image = global::CTS_beta.Properties.Resources.synchronize_32px;
            this.PicSyn.Location = new System.Drawing.Point(17, 4);
            this.PicSyn.Name = "PicSyn";
            this.PicSyn.Size = new System.Drawing.Size(32, 32);
            this.PicSyn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSyn.TabIndex = 46;
            this.PicSyn.TabStop = false;
            this.PicSyn.Click += new System.EventHandler(this.PicSyn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(375, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 54);
            this.panel1.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(734, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 38);
            this.button3.TabIndex = 37;
            this.button3.Text = "Tạo tài khoản";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Image = global::CTS_beta.Properties.Resources.close_window_20px;
            this.btnDelete.Location = new System.Drawing.Point(17, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 29);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = " Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridViewAccount);
            this.Controls.Add(this.panel3);
            this.Name = "frmAccount";
            this.Size = new System.Drawing.Size(942, 620);
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAccount.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAccount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSyn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView GridViewAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox PicSyn;
    }
}