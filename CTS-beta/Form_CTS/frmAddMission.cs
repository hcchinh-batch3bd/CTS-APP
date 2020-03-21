using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS_beta.Form_CTS
{
    public partial class frmAddMission : Form
    {
        int mov, movX, movY;

        public frmAddMission()
        {
            InitializeComponent();
        }

        private void frmAddMission_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            jTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, jTextBox1.Width, jTextBox1.Height, 10, 10));
            radDropDownList1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radDropDownList1.Width, radDropDownList1.Height, 10, 10));
            jTextBox2.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, jTextBox2.Width, jTextBox2.Height, 10, 10));
            jTextBox3.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, jTextBox3.Width, jTextBox3.Height, 10, 10));
            jTextBox4.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, jTextBox4.Width, jTextBox4.Height, 10, 10));
            button1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            richTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, richTextBox1.Width, richTextBox1.Height, 10, 10));
        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radLabel6_Click(object sender, EventArgs e)
        {

        }

        private void radLabel5_Click(object sender, EventArgs e)
        {

        }

        
        private void jTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
