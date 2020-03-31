namespace CTS_beta.Form_CTS
{
    partial class frmMissionDoing
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.PicSyn = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.radPanel1.Controls.Add(this.PicSyn);
            this.radPanel1.Controls.Add(this.label11);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1716, 51);
            this.radPanel1.TabIndex = 3;
            // 
            // PicSyn
            // 
            this.PicSyn.Image = global::CTS_beta.Properties.Resources.synchronize_32px;
            this.PicSyn.Location = new System.Drawing.Point(10, 10);
            this.PicSyn.Name = "PicSyn";
            this.PicSyn.Size = new System.Drawing.Size(32, 32);
            this.PicSyn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSyn.TabIndex = 42;
            this.PicSyn.TabStop = false;
            this.PicSyn.Click += new System.EventHandler(this.PicSyn_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(688, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(340, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "DANH SÁCH NHIỆM VỤ ĐANG LÀM";
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel2.Location = new System.Drawing.Point(0, 895);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1716, 51);
            this.radPanel2.TabIndex = 5;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radGridView1.Location = new System.Drawing.Point(0, 51);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "Tên nhiệm vụ";
            gridViewTextBoxColumn1.Name = "NameMission";
            gridViewTextBoxColumn1.Width = 698;
            gridViewTextBoxColumn2.HeaderText = "Hạn cuối hoàn thành";
            gridViewTextBoxColumn2.Name = "Date";
            gridViewTextBoxColumn2.Width = 407;
            gridViewTextBoxColumn3.HeaderText = "Loại nhiệm vụ";
            gridViewTextBoxColumn3.Name = "TypeName";
            gridViewTextBoxColumn3.Width = 176;
            gridViewTextBoxColumn4.HeaderText = "Điểm";
            gridViewTextBoxColumn4.Name = "Point";
            gridViewTextBoxColumn4.Width = 144;
            gridViewCommandColumn1.HeaderText = "Tác vụ";
            gridViewCommandColumn1.Name = "Tacvu";
            gridViewCommandColumn1.Width = 291;
            gridViewTextBoxColumn5.HeaderText = "id";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "column2";
            gridViewTextBoxColumn5.Width = 49;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCommandColumn1,
            gridViewTextBoxColumn5});
            this.radGridView1.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(1716, 844);
            this.radGridView1.TabIndex = 6;
            this.radGridView1.ThemeName = "MaterialTeal";
            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
            this.radGridView1.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellClick_1);
            // 
            // frmMissionDoing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "frmMissionDoing";
            this.Size = new System.Drawing.Size(1716, 946);
            this.Load += new System.EventHandler(this.frmMissionDoing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label label11;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.PictureBox PicSyn;
    }
}