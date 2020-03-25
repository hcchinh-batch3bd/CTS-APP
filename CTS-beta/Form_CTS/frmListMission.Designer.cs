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
            this.data = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddMission = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data.MasterTemplate)).BeginInit();
            this.data.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Controls.Add(this.panel1);
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(0, 42);
            // 
            // 
            // 
            this.data.MasterTemplate.AllowAddNewRow = false;
            this.data.MasterTemplate.AllowColumnReorder = false;
            this.data.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn1.RowSpan = 10;
            gridViewTextBoxColumn1.Width = 68;
            gridViewTextBoxColumn2.HeaderText = "Tên nhiệm vụ";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.Width = 142;
            gridViewTextBoxColumn3.HeaderText = "Loại nhiệm vụ";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 141;
            gridViewTextBoxColumn4.HeaderText = "Mô tả";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn4.Width = 263;
            gridViewTextBoxColumn5.HeaderText = "Số lượng";
            gridViewTextBoxColumn5.Name = "column4";
            gridViewTextBoxColumn5.Width = 99;
            gridViewTextBoxColumn6.HeaderText = "Trạng thái";
            gridViewTextBoxColumn6.Name = "column5";
            gridViewTextBoxColumn6.Width = 99;
            gridViewTextBoxColumn7.HeaderText = "Điểm";
            gridViewTextBoxColumn7.Name = "column6";
            gridViewTextBoxColumn7.Width = 109;
            this.data.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.data.MasterTemplate.ShowHeaderCellButtons = true;
            this.data.MasterTemplate.ShowRowHeaderColumn = false;
            this.data.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.data.Name = "data";
            // 
            // 
            // 
            this.data.RootElement.AutoSize = false;
            this.data.ShowHeaderCellButtons = true;
            this.data.Size = new System.Drawing.Size(921, 578);
            this.data.TabIndex = 8;
            this.data.ThemeName = "MaterialTeal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAddMission);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 68);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::CTS_beta.Properties.Resources.close_window_20px;
            this.button1.Location = new System.Drawing.Point(177, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 40);
            this.button1.TabIndex = 36;
            this.button1.Text = " Xóa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddMission
            // 
            this.btnAddMission.BackColor = System.Drawing.Color.White;
            this.btnAddMission.FlatAppearance.BorderSize = 0;
            this.btnAddMission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnAddMission.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMission.Image")));
            this.btnAddMission.Location = new System.Drawing.Point(12, 14);
            this.btnAddMission.Name = "btnAddMission";
            this.btnAddMission.Size = new System.Drawing.Size(158, 40);
            this.btnAddMission.TabIndex = 35;
            this.btnAddMission.Text = "Thêm nhiệm vụ";
            this.btnAddMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMission.UseVisualStyleBackColor = false;
            this.btnAddMission.Click += new System.EventHandler(this.btnAddMission_Click);
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
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(267, 14);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(158, 40);
            this.btnLoad.TabIndex = 37;
            this.btnLoad.Text = "Load dữ liệu";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmListMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(921, 620);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListMission";
            this.Load += new System.EventHandler(this.frmListMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.data.ResumeLayout(false);
            this.data.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddMission;
        private System.Windows.Forms.Button btnLoad;
    }
}