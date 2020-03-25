namespace CTS_beta.Form_CTS
{
    partial class frmListMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListMission));
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemNhiemVu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.radGridView1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Controls.Add(this.panel1);
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 42);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "column3";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.RowSpan = 100;
            gridViewTextBoxColumn1.Width = 81;
            gridViewTextBoxColumn2.HeaderText = "Tên nhiệm vụ";
            gridViewTextBoxColumn2.Name = "ID";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 193;
            gridViewTextBoxColumn3.HeaderText = "Loại nhiệm vụ";
            gridViewTextBoxColumn3.Name = "column1";
            gridViewTextBoxColumn3.Width = 136;
            gridViewTextBoxColumn4.HeaderText = "Mô tả";
            gridViewTextBoxColumn4.Name = "column2";
            gridViewTextBoxColumn4.Width = 272;
            gridViewTextBoxColumn5.HeaderText = "Số lượng";
            gridViewTextBoxColumn5.Name = "column4";
            gridViewTextBoxColumn5.Width = 89;
            gridViewTextBoxColumn6.HeaderText = "Trạng thái";
            gridViewTextBoxColumn6.Name = "column5";
            gridViewTextBoxColumn6.Width = 89;
            gridViewTextBoxColumn7.HeaderText = "Điểm";
            gridViewTextBoxColumn7.Name = "column6";
            gridViewTextBoxColumn7.Width = 61;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            // 
            // 
            // 
            this.radGridView1.RootElement.AutoSize = false;
            this.radGridView1.ShowHeaderCellButtons = true;
            this.radGridView1.Size = new System.Drawing.Size(921, 578);
            this.radGridView1.TabIndex = 8;
            this.radGridView1.ThemeName = "MaterialTeal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThemNhiemVu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 68);
            this.panel1.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Image = global::CTS_beta.Properties.Resources.close_window_20px;
            this.btnXoa.Location = new System.Drawing.Point(177, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 40);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemNhiemVu
            // 
            this.btnThemNhiemVu.BackColor = System.Drawing.Color.White;
            this.btnThemNhiemVu.FlatAppearance.BorderSize = 0;
            this.btnThemNhiemVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnThemNhiemVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNhiemVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnThemNhiemVu.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhiemVu.Image")));
            this.btnThemNhiemVu.Location = new System.Drawing.Point(12, 14);
            this.btnThemNhiemVu.Name = "btnThemNhiemVu";
            this.btnThemNhiemVu.Size = new System.Drawing.Size(158, 40);
            this.btnThemNhiemVu.TabIndex = 35;
            this.btnThemNhiemVu.Text = "Thêm nhiệm vụ";
            this.btnThemNhiemVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNhiemVu.UseVisualStyleBackColor = false;
            this.btnThemNhiemVu.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(921, 42);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(392, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH NHIỆM VỤ";
            // 
            // frmListMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.panel3);
            this.Name = "frmListMission";
            this.Size = new System.Drawing.Size(921, 620);
            this.Load += new System.EventHandler(this.frmListMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.radGridView1.ResumeLayout(false);
            this.radGridView1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemNhiemVu;
    }
}