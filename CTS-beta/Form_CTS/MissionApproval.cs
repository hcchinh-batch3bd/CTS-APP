using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS_beta.Form_CTS
{
    public partial class MissionApproval : Form
    {
        public MissionApproval()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            button1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 5, 5));
            button2.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 5, 5));
        }
    }
}
