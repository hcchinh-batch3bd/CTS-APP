using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CTS_beta
{
    public partial class frmChangePassword : Telerik.WinControls.UI.RadForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            radButton1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radButton1.Width, radButton1.Height, 5, 5));
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
