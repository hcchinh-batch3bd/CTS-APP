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
    public partial class frmAdmin : Telerik.WinControls.UI.RadForm
    {
        

        public frmAdmin()
        {
            InitializeComponent();
            ChildForm.OpenChildForm(new frmStatistical(), panel4);
            ShowMenu.customizeDesing(panel5);
            
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

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }

        private void frmAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowMenu.showSubMenu(panel5);
            //ChildForm.OpenChildForm(new MissionApproval(), panel5);
            MissionApproval childForm = new MissionApproval();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
