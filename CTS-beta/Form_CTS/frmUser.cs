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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            ChildForm.OpenChildForm(new frmMissionAreThere(), panelDesktop);
            //this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            radTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radTextBox1.Width, radTextBox1.Height, 5, 5));
            pictureBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 5, 5));

        }

        private void btnExitUser_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMissionAreThere_Click(object sender, EventArgs e)
        {
            ChildForm.OpenChildForm(new frmMissionAreThere(), panelDesktop);
        }

        private void btnMissionDoing_Click(object sender, EventArgs e)
        {
            ChildForm.OpenChildForm(new frmMissionDoing(), panelDesktop);
        }

        private void btnMissionCompleted_Click(object sender, EventArgs e)
        {
            ChildForm.OpenChildForm(new frmMissionCompleted(), panelDesktop);
        }

        private void btnCreateMission_Click(object sender, EventArgs e)
        {
            ChildForm.OpenChildForm(new frmAddMissionUser(), panelDesktop);
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
