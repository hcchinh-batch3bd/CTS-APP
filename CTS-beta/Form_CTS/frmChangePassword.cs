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

                }
                catch
                {

                }
            }
            else
                MessageBox.Show("Mật khẩu mới và mật khẩu mới nhập lại không giống nhau !!");
        }
    }
}
