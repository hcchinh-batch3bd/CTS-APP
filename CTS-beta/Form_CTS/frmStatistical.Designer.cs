namespace CTS_beta
{
    partial class frmStatistical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistical));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data = new Telerik.WinControls.UI.RadGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 40);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(426, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "THỐNG KÊ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 42);
            this.panel1.TabIndex = 10;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Honeydew;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(755, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(158, 35);
            this.btnExcel.TabIndex = 30;
            this.btnExcel.Text = "Xuất file excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.data);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 538);
            this.panel2.TabIndex = 11;
            // 
            // data
            // 
            this.data.Dock = System.Windows.Forms.DockStyle.Top;
            this.data.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.data.MasterTemplate.AllowAddNewRow = false;
            this.data.MasterTemplate.AllowColumnReorder = false;
            this.data.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.HeaderText = "Vị trí";
            gridViewTextBoxColumn5.Name = "column3";
            gridViewTextBoxColumn5.RowSpan = 10;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 97;
            gridViewTextBoxColumn6.HeaderText = "ID";
            gridViewTextBoxColumn6.Name = "ID";
            gridViewTextBoxColumn6.Width = 119;
            gridViewTextBoxColumn7.HeaderText = "Tên nhân viên";
            gridViewTextBoxColumn7.Name = "column1";
            gridViewTextBoxColumn7.Width = 521;
            gridViewTextBoxColumn8.HeaderText = "Điểm số";
            gridViewTextBoxColumn8.Name = "column2";
            gridViewTextBoxColumn8.Width = 205;
            this.data.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.data.MasterTemplate.ShowRowHeaderColumn = false;
            this.data.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // 
            // 
            this.data.RootElement.AutoSize = false;
            this.data.Size = new System.Drawing.Size(942, 538);
            this.data.TabIndex = 9;
            this.data.ThemeName = "MaterialTeal";
            // 
            // frmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "frmStatistical";
            this.Size = new System.Drawing.Size(942, 620);
            this.Load += new System.EventHandler(this.frmStatistical_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadGridView data;
    }
}