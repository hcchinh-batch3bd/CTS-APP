﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using CTS_beta.Form_CTS;
using System.Web;
using Newtonsoft.Json;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Threading;

namespace CTS_beta
{
    public partial class frmChangePassword : Telerik.WinControls.UI.RadForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPasswordOld.Text == "")
                MessageBox.Show("Vui lòng nhập vào mật khẩu cũ !!");
            else
            if (txtPasswordNew.Text == "")
                MessageBox.Show("Vui lòng nhập vào mật khẩu mới !!");
            else
            if (txtPasswordNewComfirm.Text == "")
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới !!");
            else
            if (txtPasswordNew.Text.Equals(txtPasswordNewComfirm.Text))
            {
                if(CheckPassword(txtPasswordNew.Text))
                {
                    if (!txtPasswordNew.Text.Equals(txtPasswordOld.Text))
                    {
                    Load:
                        radWaitingBar1.Refresh();
                        radWaitingBar1.Visible = true;
                        radWaitingBar1.StartWaiting();
                        IRestResponse response = null;
                        Thread t = new Thread(() =>
                        {
                            string pwold = HttpUtility.UrlEncode(txtPasswordOld.Text);
                            string pwnew = HttpUtility.UrlEncode(txtPasswordNew.Text);
                            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Account/Changepassword?passold=" + pwold + "&passnew=" + pwnew + "&apiKey=" + frmUser.Instance.ApiKey);
                            var request = new RestRequest(Method.PUT);
                            response = client.Execute(request);
                        })
                        { IsBackground = true };
                        t.Start();
                        while (t.IsAlive)
                        {
                            Application.DoEvents();
                            btnChangePassword.Enabled = false;
                        }
                        radWaitingBar1.StopWaiting();
                        radWaitingBar1.Visible = false;
                        btnChangePassword.Enabled = true;
                        if (!response.IsSuccessful)
                        {
                            DialogResult dialog = MessageBox.Show("Máy chủ bị mất kết nối !!!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (dialog == DialogResult.Retry)
                                goto Load;
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            Message obj = JsonConvert.DeserializeObject<Message>(response.Content.ToString());
                            if (obj.status)
                            {
                                Properties.Settings.Default.apiKey = "";
                                Properties.Settings.Default.Save();
                                Application.Exit();
                            }
                            else
                                MessageBox.Show(obj.message);
                        }
                    }
                    else
                        MessageBox.Show("Mật khẩu cần đổi phải khác mật khẩu hiện tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               else
                    MessageBox.Show("➻❥ Mật khẩu phải dài từ 8 đến 30 ký tự.\n➻❥ Mật phải chứa ít nhất một số.\n➻❥ Mật khẩu phải chứa ít nhất một chữ cái viết hoa.\n➻❥ Mật khẩu phải chứa ít nhất một chữ cái viết thường\n➻❥ Mật khẩu phải chứa ít nhất một kí tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Mật khẩu mới và mật khẩu mới nhập lại không giống nhau !!");
        }
        public class Message
        {
            public string message { get; set; }
            public bool status { get; set; }
        }

        private void frmChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public bool CheckPassword(string password)
        {
            string MatchEmailPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,30}$";

            if (password != null) return Regex.IsMatch(password, MatchEmailPattern);
            else return false;


        }

        private void txtPasswordNewComfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChangePassword_Click(this, new EventArgs());
            }
        }
    }

}
