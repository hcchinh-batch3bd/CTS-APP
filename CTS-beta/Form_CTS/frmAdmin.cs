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
        private Form currentChildForm;

        public frmUser()
        {
            InitializeComponent();
            OpenChildForm(new frmStatistical());
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            //textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 20, 20));
        }

       

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label3.Text = childForm.Text;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddMission());
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStatistical());
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
