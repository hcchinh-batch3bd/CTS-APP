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
    public partial class MissionApproval : UserControl
    {
        int id;
        public MissionApproval(int id, string content)
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            btnAccept.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnAccept.Width, btnAccept.Height, 5, 5));
            btnClose.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnClose.Width, btnClose.Height, 5, 5));
            this.id = id;
            lblContent.Text = content;
        }

        private void lblContent_Click(object sender, EventArgs e)
        {
            frmDetailMission frmDetailMission = new frmDetailMission();
            frmDetailMission.ShowDialog();
        }
    }
}
