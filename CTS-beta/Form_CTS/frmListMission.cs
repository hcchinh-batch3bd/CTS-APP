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
    public partial class frmListMission : Form
    {
        public frmListMission()
        {
            InitializeComponent();
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AutoExpandGroups = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddMission fAdd = new frmAddMission();
            fAdd.Show();
        }

        private void frmListMission_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            button1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 5, 5));
            button2.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 5, 5));
        }
    }
}
