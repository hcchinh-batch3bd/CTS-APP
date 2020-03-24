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
    public partial class frmForgotPassword : Telerik.WinControls.UI.RadForm
    {
        public frmForgotPassword()
        {
            InitializeComponent();
            radButton1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radButton1.Width, radButton1.Height, 5, 5));
        }
    }
}
