using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Configuration;
using CTS_beta.Models;
using CTS_beta.Form_CTS;

namespace CTS_beta
{
    public partial class frmLogin : Telerik.WinControls.UI.RadForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            btnLogin.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 5, 5));
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword fForgotPass = new frmForgotPassword();
            fForgotPass.Show();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Vui lòng không được bỏ trống !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                var client = new RestClient(ConfigurationSettings.AppSettings["server"] + "/Account/CheckLogin?id=" + txtID.Text + "&pw=" + txtPassword.Text);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                try
                {
                    RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                    List<Session> sessions = obj.results;
                    MessageBox.Show(obj.message);
                    if (sessions.Count > 0)
                    {
                        if (ckbRemember.Checked)
                        {
                            Properties.Settings.Default.apiKey = sessions.FirstOrDefault().apiKey;
                            Properties.Settings.Default.Save();
                        }
                        if (sessions.FirstOrDefault().level_employee)
                        {
                            frmAdmin frmAdmin = new frmAdmin(this, sessions.FirstOrDefault().apiKey);
                            frmAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            frmUser frmUser = new frmUser(this, sessions.FirstOrDefault().apiKey);
                            frmUser.Show();
                            this.Hide();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Máy chủ " + ConfigurationSettings.AppSettings["server"] + " không thể kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        class RootObject
        {
            public List<Session> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ckbRemember_CheckStateChanging(object sender, CheckStateChangingEventArgs args)
        {
            MessageBox.Show("Nếu bạn bật chức năng này hệ thống sẽ không yêu cầu đăng nhập cho lần tới !!", "Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
