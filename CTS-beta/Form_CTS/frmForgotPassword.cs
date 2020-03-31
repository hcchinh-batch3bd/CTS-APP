using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CTS_beta
{
    public partial class frmForgotPassword : Telerik.WinControls.UI.RadForm
    {
        public frmForgotPassword()
        {
            InitializeComponent();
            btnSendCode.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnSendCode.Width, btnSendCode.Height, 5, 5));
        }
        int otp;
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                Random random = new Random();
                int otpcode = random.Next(000000, 999999);
                otp = otpcode;
                string otpEcrypt = Encrypt(otpcode.ToString());
                var client = new RestClient("http://localhost:1037/Account/OTP?OTP=" + otpEcrypt + "&mail=" + txtEmail.Text);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                Message obj = JsonConvert.DeserializeObject<Message>(response.Content.ToString());
                MessageBox.Show(obj.message);
            }
            else
                MessageBox.Show("Vui lòng nhập email !!");
        }
        public static string Encrypt(string originalString)
        {
            if (String.IsNullOrEmpty(originalString))
            {
                throw new ArgumentNullException
                       ("The string which needs to be encrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }
        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("OTPCTS12");
        public class Message
        {
            public string message { get; set; }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text.Equals(otp.ToString()))
            {
                if (txtPassword.Text != "")
                {

                }
                else
                    MessageBox.Show("Vui lòng nhập mật khẩu mới !!");
            }
            else
                MessageBox.Show("Mã OTP không chính xác !!");
        }

        private void frmForgotPassword_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void frmForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin fL = new frmLogin();
            fL.Show();
            this.Hide();
        }
    }
}
