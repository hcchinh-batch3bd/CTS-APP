namespace CTS_beta
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(566, 208);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(148, 172);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(150, 200);
            this.radCollapsiblePanel1.TabIndex = 0;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 613);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmUser";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
    }
}
