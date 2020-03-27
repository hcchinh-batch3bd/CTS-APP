namespace CTS_beta.Form_CTS
{
    partial class frmMissionAreThere
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.label11 = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicSyn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.radGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSyn)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(571, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(329, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "DANH SÁCH NHIỆM VỤ ĐANG CÓ";
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.radPanel1.Controls.Add(this.PicSyn);
            this.radPanel1.Controls.Add(this.label11);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1386, 51);
            this.radPanel1.TabIndex = 5;
            // 
            // radGridView1
            // 
            this.radGridView1.Controls.Add(this.pictureBox1);
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 51);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn22.HeaderText = "ID Nhiệm vụ";
            gridViewTextBoxColumn22.Name = "column6";
            gridViewTextBoxColumn22.Width = 95;
            gridViewTextBoxColumn23.HeaderText = "Tên nhiệm vụ";
            gridViewTextBoxColumn23.Name = "column1";
            gridViewTextBoxColumn23.Width = 264;
            gridViewTextBoxColumn24.HeaderText = "Mô tả";
            gridViewTextBoxColumn24.Name = "column7";
            gridViewTextBoxColumn24.Width = 378;
            gridViewTextBoxColumn25.HeaderText = "Ngày bắt đầu";
            gridViewTextBoxColumn25.Name = "column2";
            gridViewTextBoxColumn25.Width = 150;
            gridViewTextBoxColumn26.HeaderText = "Ngày kết thúc";
            gridViewTextBoxColumn26.Name = "column8";
            gridViewTextBoxColumn26.Width = 136;
            gridViewTextBoxColumn27.HeaderText = "Loại nhiệm vụ";
            gridViewTextBoxColumn27.Name = "column3";
            gridViewTextBoxColumn27.Width = 121;
            gridViewTextBoxColumn28.HeaderText = "Điểm";
            gridViewTextBoxColumn28.Name = "column4";
            gridViewTextBoxColumn28.Width = 85;
            gridViewCommandColumn4.HeaderText = "Tác vụ";
            gridViewCommandColumn4.Name = "TacVu";
            gridViewCommandColumn4.Width = 157;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewTextBoxColumn27,
            gridViewTextBoxColumn28,
            gridViewCommandColumn4});
            this.radGridView1.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(1386, 686);
            this.radGridView1.TabIndex = 8;
            this.radGridView1.ThemeName = "MaterialTeal";
            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
            this.radGridView1.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellClick);
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel2.Location = new System.Drawing.Point(0, 737);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1386, 51);
            this.radPanel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PicSyn
            // 
            this.PicSyn.Image = global::CTS_beta.Properties.Resources.synchronize_32px;
            this.PicSyn.Location = new System.Drawing.Point(10, 10);
            this.PicSyn.Name = "PicSyn";
            this.PicSyn.Size = new System.Drawing.Size(32, 32);
            this.PicSyn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSyn.TabIndex = 41;
            this.PicSyn.TabStop = false;
            this.PicSyn.Click += new System.EventHandler(this.PicSyn_Click);
            // 
            // frmMissionAreThere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "frmMissionAreThere";
            this.Size = new System.Drawing.Size(1386, 788);
            this.Load += new System.EventHandler(this.frmMissionAreThere_load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.radGridView1.ResumeLayout(false);
            this.radGridView1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSyn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private System.Windows.Forms.Label label11;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.PictureBox PicSyn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}