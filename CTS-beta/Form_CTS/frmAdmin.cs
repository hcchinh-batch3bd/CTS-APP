using CTS_beta.Form_CTS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CTS_beta
{
    public partial class frmUser : Telerik.WinControls.UI.RadForm
    {
        

        public frmUser()
        {
            InitializeComponent();
            ChildForm.OpenChildForm(new frmStatistical(), panel4);
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            ChildForm.OpenChildForm(new frmStatistical(), panel4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            ChildForm.OpenChildForm(new frmListMission(), panel4);
        }

        private void frmUser_Load_1(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            ChildForm.OpenChildForm(new frmTypeMission(), panel4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            ChildForm.OpenChildForm(new frmAccount(), panel4);
        }
    }
}
