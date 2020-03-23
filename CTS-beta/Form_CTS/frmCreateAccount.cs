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
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            button1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 5, 5));
            button2.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 5, 5));
            radTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radTextBox1.Width, radTextBox1.Height, 5, 5));
            radDateTimePicker1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radDateTimePicker1.Width, radDateTimePicker1.Height, 5, 5));
            radTextBox2.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radTextBox2.Width, radTextBox2.Height, 5, 5));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmCreateAccount_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
