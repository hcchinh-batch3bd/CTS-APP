using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTS_beta.Models;
using Newtonsoft.Json;
using System.Threading;
using RestSharp;

namespace CTS_beta.Form_CTS
{
    public partial class frmListMission : UserControl
    {
        public frmListMission()
        {
            InitializeComponent();
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AutoExpandGroups = false;
        }

        private void frmListMission_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            btnXoa.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnXoa.Width, btnXoa.Height, 5, 5));
            btnThemNhiemVu.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnThemNhiemVu.Width, btnThemNhiemVu.Height, 5, 5));

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmAddMission fAdd = new frmAddMission();
            fAdd.Show();
        }
      
    }
}
