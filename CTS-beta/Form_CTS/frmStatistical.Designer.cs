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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.ctsButton1 = new CTS_beta.CTSButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.jTextBox1 = new JTextBox.JTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // ctsButton1
            // 
            this.ctsButton1.BackColor = System.Drawing.Color.Transparent;
            this.ctsButton1.BorderColor = System.Drawing.Color.Transparent;
            this.ctsButton1.ButtonColor = System.Drawing.Color.RoyalBlue;
            this.ctsButton1.FlatAppearance.BorderSize = 0;
            this.ctsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctsButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctsButton1.Location = new System.Drawing.Point(353, 528);
            this.ctsButton1.Name = "ctsButton1";
            this.ctsButton1.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.ctsButton1.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.ctsButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.ctsButton1.Size = new System.Drawing.Size(73, 46);
            this.ctsButton1.TabIndex = 6;
            this.ctsButton1.Text = "Thêm mới";
            this.ctsButton1.TextColor = System.Drawing.Color.White;
            this.ctsButton1.UseVisualStyleBackColor = false;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.HeaderText = "Vị trí";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.Name = "column3";
            gridViewTextBoxColumn1.RowSpan = 10;
            gridViewTextBoxColumn1.Width = 39;
            gridViewTextBoxColumn2.HeaderText = "ID";
            gridViewTextBoxColumn2.Name = "ID";
            gridViewTextBoxColumn2.Width = 218;
            gridViewTextBoxColumn3.HeaderText = "Tên nhân viên";
            gridViewTextBoxColumn3.Name = "column1";
            gridViewTextBoxColumn3.Width = 322;
            gridViewTextBoxColumn4.HeaderText = "Điểm số";
            gridViewTextBoxColumn4.Name = "column2";
            gridViewTextBoxColumn4.Width = 294;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            // 
            // 
            // 
            this.radGridView1.RootElement.AutoSize = false;
            this.radGridView1.Size = new System.Drawing.Size(921, 500);
            this.radGridView1.TabIndex = 8;
            this.radGridView1.ThemeName = "MaterialTeal";
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // jTextBox1
            // 
            this.jTextBox1.AutoSize = true;
            this.jTextBox1.BorderColor = System.Drawing.Color.Black;
            this.jTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jTextBox1.Hint = "";
            this.jTextBox1.IsPassword = false;
            this.jTextBox1.Length = 0;
            this.jTextBox1.Location = new System.Drawing.Point(75, 529);
            this.jTextBox1.Name = "jTextBox1";
            this.jTextBox1.OnFocus = System.Drawing.Color.DarkGray;
            this.jTextBox1.OnlyChar = false;
            this.jTextBox1.OnlyNumber = false;
            this.jTextBox1.Size = new System.Drawing.Size(252, 39);
            this.jTextBox1.TabIndex = 9;
            this.jTextBox1.TextValue = "";
            // 
            // frmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(921, 610);
            this.Controls.Add(this.jTextBox1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.ctsButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStatistical";
            this.Text = "THỐNG KÊ";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private CTSButton ctsButton1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private JTextBox.JTextBox jTextBox1;
    }
}