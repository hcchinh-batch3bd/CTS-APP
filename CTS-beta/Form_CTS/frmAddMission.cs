﻿using System;
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

        public frmAddMission()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            jTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, jTextBox1.Width, jTextBox1.Height, 10, 10));
            radDropDownList1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radDropDownList1.Width, radDropDownList1.Height, 10, 10));
            jTextBox2.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, jTextBox2.Width, jTextBox2.Height, 10, 10));
            jTextBox3.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, jTextBox3.Width, jTextBox3.Height, 10, 10));
            jTextBox4.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, jTextBox4.Width, jTextBox4.Height, 10, 10));
            button1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            richTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, richTextBox1.Width, richTextBox1.Height, 10, 10));
        }
        
        

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddMission_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmAddMission_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
