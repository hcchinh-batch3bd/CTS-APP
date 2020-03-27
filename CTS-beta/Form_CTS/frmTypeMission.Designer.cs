namespace CTS_beta.Form_CTS
{
    partial class frmTypeMission
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.data = new Telerik.WinControls.UI.RadGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaddnametypemisson = new JTextBox2.JTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.PicSyn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data.MasterTemplate)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSyn)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(0, 151);
            // 
            // 
            // 
            this.data.MasterTemplate.AllowAddNewRow = false;
            this.data.MasterTemplate.AllowColumnReorder = false;
            this.data.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.RowSpan = 50;
            gridViewTextBoxColumn1.Width = 119;
            gridViewTextBoxColumn2.HeaderText = "Loại nhiệm vụ";
            gridViewTextBoxColumn2.Name = "nameType";
            gridViewTextBoxColumn2.Width = 598;
            gridViewTextBoxColumn3.HeaderText = "Trạng thái";
            gridViewTextBoxColumn3.Name = "Status";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 208;
            this.data.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.data.MasterTemplate.ShowHeaderCellButtons = true;
            this.data.MasterTemplate.ShowRowHeaderColumn = false;
            this.data.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.data.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.data.Name = "data";
            // 
            // 
            // 
            this.data.RootElement.AutoSize = false;
            this.data.ShowHeaderCellButtons = true;
            this.data.Size = new System.Drawing.Size(942, 398);
            this.data.TabIndex = 8;
            this.data.ThemeName = "MaterialTeal";
            this.data.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.data_CellValueChanged);
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 42);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.PicSyn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 42);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(403, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOẠI NHIỆM VỤ";
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
            // txtaddnametypemisson
            // 
            this.txtaddnametypemisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtaddnametypemisson.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtaddnametypemisson.HintText = null;
            this.txtaddnametypemisson.IsPassword = false;
            this.txtaddnametypemisson.Location = new System.Drawing.Point(217, 74);
            this.txtaddnametypemisson.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddnametypemisson.MaxLength = 32767;
            this.txtaddnametypemisson.Name = "txtaddnametypemisson";
            this.txtaddnametypemisson.OnFocusedColor = System.Drawing.Color.White;
            this.txtaddnametypemisson.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtaddnametypemisson.ReadOnly = false;
            this.txtaddnametypemisson.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtaddnametypemisson.Size = new System.Drawing.Size(356, 44);
            this.txtaddnametypemisson.TabIndex = 27;
            this.txtaddnametypemisson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtaddnametypemisson.TextName = "";
            this.txtaddnametypemisson.Load += new System.EventHandler(this.jTextBox1_Load);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radLabel1.Location = new System.Drawing.Point(72, 84);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(142, 22);
            this.radLabel1.TabIndex = 26;
            this.radLabel1.Text = "Tên loại nhiệm vụ:";
            this.radLabel1.Click += new System.EventHandler(this.radLabel1_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDel.Image = global::CTS_beta.Properties.Resources.close_window_30px;
            this.btnDel.Location = new System.Drawing.Point(732, 73);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 45);
            this.btnDel.TabIndex = 28;
            this.btnDel.Text = " Xóa";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Image = global::CTS_beta.Properties.Resources.add_new_32px;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(592, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 44);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 68);
            this.panel2.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Image = global::CTS_beta.Properties.Resources.imgpsh_fullsize_anim;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(829, 74);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 44);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // PicSyn
            // 
            this.PicSyn.Image = global::CTS_beta.Properties.Resources.synchronize_32px;
            this.PicSyn.Location = new System.Drawing.Point(18, 5);
            this.PicSyn.Name = "PicSyn";
            this.PicSyn.Size = new System.Drawing.Size(32, 32);
            this.PicSyn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSyn.TabIndex = 45;
            this.PicSyn.TabStop = false;
            this.PicSyn.Click += new System.EventHandler(this.PicSyn_Click);
            // 
            // frmTypeMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtaddnametypemisson);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel3);
            this.Name = "frmTypeMission";
            this.Size = new System.Drawing.Size(942, 620);
            this.Load += new System.EventHandler(this.frmTypeMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSyn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private JTextBox2.JTextBox txtaddnametypemisson;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox PicSyn;
    }
}