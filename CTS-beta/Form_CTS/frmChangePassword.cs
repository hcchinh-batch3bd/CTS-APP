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
                var client = new RestClient(System.Configuration.ConfigurationSettings.AppSettings["server"]+"/Account/Changepassword?passold="+txtPasswordOld.Text+"&passnew="+txtPasswordNew.Text+"&apiKey="+frmUser.Instance.ApiKey);
                var request = new RestRequest(Method.PUT);
                IRestResponse response = client.Execute(request);
                try
                {
                    Message obj = JsonConvert.DeserializeObject<Message>(response.Content.ToString());
                    MessageBox.Show(obj.message);
                    Properties.Settings.Default.apiKey = "";
                    Properties.Settings.Default.Save();
                    Application.Exit();
                }
                catch
                {
                    MessageBox.Show("Server bị mất kết nối");
                }
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
    }

}
