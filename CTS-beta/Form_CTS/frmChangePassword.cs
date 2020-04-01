using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using CTS_beta.Form_CTS;
using Newtonsoft.Json;
using System.Configuration;
using System.Text.RegularExpressions;

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
            if (txtPasswordNew.Text == "")
                MessageBox.Show("Vui lòng nhập vào mật khẩu mới !!");
            if (txtPasswordNewComfirm.Text == "")
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới !!");
            if (txtPasswordNew.Text.Equals(txtPasswordNewComfirm.Text))
            {
                if(CheckPassword(txtPasswordNew.Text))
                {
                    Load:
                    var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Account/Changepassword?passold=" + txtPasswordOld.Text + "&passnew=" + txtPasswordNew.Text + "&apiKey=" + frmUser.Instance.ApiKey);
                    var request = new RestRequest(Method.PUT);
                    IRestResponse response = client.Execute(request);
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
                        MessageBox.Show(obj.message);
                        Properties.Settings.Default.apiKey = "";
                        Properties.Settings.Default.Save();
                        Application.Exit();
                    }
                }
               else
                    MessageBox.Show("Mật khẩu phải dài từ 8 đến 30 ký tự.\nMật phải chứa ít nhất một số.\nMật khẩu phải chứa ít nhất một chữ cái viết hoa.\nMật khẩu phải chứa ít nhất một chữ cái viết thường\nMật khẩu phải chứa ít nhất một kí tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Mật khẩu mới và mật khẩu mới nhập lại không giống nhau !!");
        }
        public class Message
        {
            public string message { get; set; }
        }

        private void frmChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public bool CheckPassword(string password)
        {
            string MatchEmailPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$";

            if (password != null) return Regex.IsMatch(password, MatchEmailPattern);
            else return false;


        }
    }

}
