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
            this.components = new System.ComponentModel.Container();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddMission = new System.Windows.Forms.Button();
            this.PicSyn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data.MasterTemplate)).BeginInit();
            this.data.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSyn)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.ContextMenuStrip = this.contextMenuStrip1;
            this.data.Controls.Add(this.panel1);
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(0, 42);
            // 
            // 
            // 
            this.data.MasterTemplate.AllowAddNewRow = false;
            this.data.MasterTemplate.AllowCellContextMenu = false;
            this.data.MasterTemplate.AllowColumnReorder = false;
            this.data.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn1.RowSpan = 10;
            gridViewTextBoxColumn1.Width = 70;
            gridViewTextBoxColumn2.HeaderText = "Tên nhiệm vụ";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.Width = 145;
            gridViewTextBoxColumn3.HeaderText = "Loại nhiệm vụ";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 144;
            gridViewTextBoxColumn4.HeaderText = "Mô tả";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn4.Width = 269;
            gridViewTextBoxColumn5.HeaderText = "Số lượng";
            gridViewTextBoxColumn5.Name = "column4";
            gridViewTextBoxColumn5.Width = 101;
            gridViewTextBoxColumn6.HeaderText = "Trạng thái";
            gridViewTextBoxColumn6.Name = "status";
            gridViewTextBoxColumn6.Width = 101;
            gridViewTextBoxColumn7.HeaderText = "Điểm";
            gridViewTextBoxColumn7.Name = "column6";
            gridViewTextBoxColumn7.Width = 112;
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
            this.data.ReadOnly = true;
            // 
            // 
            // 
            this.data.RootElement.AutoSize = false;
            this.data.ShowHeaderCellButtons = true;
            this.data.Size = new System.Drawing.Size(942, 578);
            this.data.TabIndex = 8;
            this.data.ThemeName = "MaterialTeal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAddMission);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 54);
            this.panel1.TabIndex = 10;
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(403, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH NHIỆM VỤ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnView,
            this.btnEdit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 48);
            // 
            // btnView
            // 
            this.btnView.Image = global::CTS_beta.Properties.Resources.eye;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(137, 22);
            this.btnView.Text = "Xem chi tiết";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::CTS_beta.Properties.Resources.test;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 22);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.button1.Location = new System.Drawing.Point(173, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 40);
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
            this.btnAddMission.Location = new System.Drawing.Point(9, 7);
            this.btnAddMission.Name = "btnAddMission";
            this.btnAddMission.Size = new System.Drawing.Size(158, 40);
            this.btnAddMission.TabIndex = 35;
            this.btnAddMission.Text = "Thêm nhiệm vụ";
            this.btnAddMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMission.UseVisualStyleBackColor = false;
            this.btnAddMission.Click += new System.EventHandler(this.btnAddMission_Click);
            // 
            // PicSyn
            // 
            this.PicSyn.Image = global::CTS_beta.Properties.Resources.synchronize_32px;
            this.PicSyn.Location = new System.Drawing.Point(8, 5);
            this.PicSyn.Name = "PicSyn";
            this.PicSyn.Size = new System.Drawing.Size(32, 32);
            this.PicSyn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSyn.TabIndex = 43;
            this.PicSyn.TabStop = false;
            this.PicSyn.Click += new System.EventHandler(this.PicSyn_Click);
            // 
            // frmListMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel3);
            this.Name = "frmListMission";
            this.Size = new System.Drawing.Size(942, 620);
            this.Load += new System.EventHandler(this.frmListMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.data.ResumeLayout(false);
            this.data.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicSyn)).EndInit();
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
        private System.Windows.Forms.PictureBox PicSyn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnView;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
    }
}