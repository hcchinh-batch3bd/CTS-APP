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
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 20;
            if(panel2.Width >= 700)
            {
                timer1.Stop();
                frmLogin fu = new frmLogin();
                fu.Show();
                this.Hide();
            }
        }
    }
}
