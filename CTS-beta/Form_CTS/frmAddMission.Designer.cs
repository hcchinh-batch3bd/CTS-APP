namespace CTS_beta.Form_CTS
{
    partial class frmAddMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMission));
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.ddlTypeMission = new Telerik.WinControls.UI.RadDropDownList();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtDescribe = new System.Windows.Forms.RichTextBox();
            this.txtNameMission = new Telerik.WinControls.UI.RadTextBox();
            this.txtExprie = new Telerik.WinControls.UI.RadTextBox();
            this.txtPoint = new Telerik.WinControls.UI.RadTextBox();
            this.txtCount = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTypeMission)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExprie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radLabel2.Location = new System.Drawing.Point(48, 303);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(78, 22);
            this.radLabel2.TabIndex = 23;
            this.radLabel2.Text = "Nội dung:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radLabel1.Location = new System.Drawing.Point(45, 70);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(112, 22);
            this.radLabel1.TabIndex = 23;
            this.radLabel1.Text = "Tên nhiệm vụ:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radLabel3.Location = new System.Drawing.Point(45, 149);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(115, 22);
            this.radLabel3.TabIndex = 23;
            this.radLabel3.Text = "Loại nhiệm vụ:";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radLabel6.Location = new System.Drawing.Point(274, 148);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(77, 22);
            this.radLabel6.TabIndex = 23;
            this.radLabel6.Text = "Số lượng:";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radLabel4.Location = new System.Drawing.Point(45, 225);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(132, 22);
            this.radLabel4.TabIndex = 23;
            this.radLabel4.Text = "Số ngày hết hạn:";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radLabel5.Location = new System.Drawing.Point(274, 225);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(73, 22);
            this.radLabel5.TabIndex = 23;
            this.radLabel5.Text = "Điểm số:";
            // 
            // ddlTypeMission
            // 
            this.ddlTypeMission.BackColor = System.Drawing.Color.White;
            this.ddlTypeMission.ItemHeight = 48;
            this.ddlTypeMission.Location = new System.Drawing.Point(48, 174);
            this.ddlTypeMission.Name = "ddlTypeMission";
            this.ddlTypeMission.Size = new System.Drawing.Size(209, 36);
            this.ddlTypeMission.TabIndex = 2;
            this.ddlTypeMission.ThemeName = "MaterialTeal";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 42);
            this.panel3.TabIndex = 29;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseDown);
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
            this.button13.Location = new System.Drawing.Point(410, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(42, 42);
            this.button13.TabIndex = 30;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "THÊM NHIỆM VỤ";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNew.Image = global::CTS_beta.Properties.Resources.add_new_32px;
            this.btnAddNew.Location = new System.Drawing.Point(160, 544);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(132, 47);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // txtDescribe
            // 
            this.txtDescribe.BackColor = System.Drawing.Color.White;
            this.txtDescribe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescribe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescribe.Location = new System.Drawing.Point(52, 330);
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(356, 189);
            this.txtDescribe.TabIndex = 6;
            this.txtDescribe.Text = "";
            // 
            // txtNameMission
            // 
            this.txtNameMission.Location = new System.Drawing.Point(48, 97);
            this.txtNameMission.Name = "txtNameMission";
            this.txtNameMission.Size = new System.Drawing.Size(360, 36);
            this.txtNameMission.TabIndex = 1;
            this.txtNameMission.ThemeName = "MaterialTeal";
            // 
            // txtExprie
            // 
            this.txtExprie.Location = new System.Drawing.Point(48, 253);
            this.txtExprie.Name = "txtExprie";
            this.txtExprie.Size = new System.Drawing.Size(209, 36);
            this.txtExprie.TabIndex = 4;
            this.txtExprie.ThemeName = "MaterialTeal";
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(274, 253);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(134, 36);
            this.txtPoint.TabIndex = 5;
            this.txtPoint.ThemeName = "MaterialTeal";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(274, 174);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(134, 36);
            this.txtCount.TabIndex = 3;
            this.txtCount.ThemeName = "MaterialTeal";
            // 
            // frmAddMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(453, 620);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtExprie);
            this.Controls.Add(this.txtNameMission);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ddlTypeMission);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabel2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.Load += new System.EventHandler(this.FrmAddMission_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAddMission_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTypeMission)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExprie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.Button btnAddNew;
        private Telerik.WinControls.UI.RadDropDownList ddlTypeMission;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.RichTextBox txtDescribe;
        private Telerik.WinControls.UI.RadTextBox txtNameMission;
        private Telerik.WinControls.UI.RadTextBox txtExprie;
        private Telerik.WinControls.UI.RadTextBox txtPoint;
        private Telerik.WinControls.UI.RadTextBox txtCount;
    }
}