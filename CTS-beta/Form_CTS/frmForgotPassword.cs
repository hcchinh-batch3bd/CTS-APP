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
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CTS_beta
{
    public partial class frmForgotPassword : Telerik.WinControls.UI.RadForm
    {
        frmLogin frm;
        int count = 60;
        int timeCode = 5;
        string apiKey = "";
        public frmForgotPassword(frmLogin frm)
        {
            InitializeComponent();
            btnChangePass.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnChangePass.Width, btnChangePass.Height, 5, 5));
            this.frm = frm;
        }
        int otp;
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && IsValidEmail(txtEmail.Text))
            {
                Random random = new Random();
                int otpcode = random.Next(0000000, 999999);
                otp = otpcode;
                string otpEcrypt = Encrypt(otpcode.ToString());
            Load:
                radWaitingBar1.Refresh();
                radWaitingBar1.Visible = true;
                radWaitingBar1.StartWaiting();
                IRestResponse response = null;
                Thread t = new Thread(() =>
                {
                    var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Account/OTP?OTP=" + otpEcrypt + "&mail=" + txtEmail.Text);
                    var request = new RestRequest(Method.GET);
                    response = client.Execute(request);
                })
                { IsBackground = true};
                t.Start();
                while(t.IsAlive)
                {
                    Application.DoEvents();
                    btnSendCode.Enabled = false;
                }
                btnSendCode.Enabled = true;
                radWaitingBar1.StopWaiting();
                radWaitingBar1.Enabled = true;
                if (!response.IsSuccessful)
                {
                    DialogResult dialog = MessageBox.Show("☠ Máy chủ bị mất kết nối !!!", "☠ Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
                    MessageBox.Show(obj.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (obj.code == 1)
                    {
                        btnSendCode.Enabled = false;
                        btnSendCode.Image = null;
                        btnSendCode.Text = "";
                        timer1.Start();
                        apiKey = Decrypt(obj.secretcode);
                        timer2.Start();

                    }
                }
            }
            else
                MessageBox.Show("Xin vui lòng nhập email !!");
        }
        public class Message
        {
            public string message { get; set; }
            public int code { get; set; }
            public string secretcode { get; set; }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text.Equals(otp.ToString()))
            {
                if (txtPassword.Text != "")
                {
                    if (txtPasswordComfirm.Text != "")
                        if (txtPassword.Text.Equals(txtPasswordComfirm.Text))
                            if (CheckPassword(txtPassword.Text))
                            {
                                if (timeCode != 0)
                                {
                                    string passnew = HttpUtility.UrlEncode(txtPassword.Text);
                                    Load:
                                    radWaitingBar1.Refresh();
                                    radWaitingBar1.Visible = true;
                                    radWaitingBar1.StartWaiting();
                                    IRestResponse response = null;
                                    Thread t = new Thread(() =>
                                    {
                                        var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Account/ChangepasswordOTP?passnew=" + passnew + "&apiKey=" + HttpUtility.UrlEncode(apiKey));
                                        var request = new RestRequest(Method.PUT);
                                        response = client.Execute(request);
                                    })
                                    { IsBackground = true };
                                    t.Start();
                                    while (t.IsAlive)
                                    {
                                        Application.DoEvents();
                                        btnChangePass.Enabled = false;
                                    }
                                    btnChangePass.Enabled = true;
                                    radWaitingBar1.StopWaiting();
                                    radWaitingBar1.Visible = false;
                                    if (!response.IsSuccessful)
                                    {
                                        DialogResult dialog = MessageBox.Show("☠ Máy chủ bị mất kết nối !!!", "☠ Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                        if (dialog == DialogResult.Retry)
                                            goto Load;
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        Message obj = JsonConvert.DeserializeObject<Message>(response.Content.ToString());
                                        MessageBox.Show(obj.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                }
                                else
                                    MessageBox.Show("Mã code đã hết hạn !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                                MessageBox.Show("Mật khẩu phải dài từ 8 đến 30 ký tự.\nMật phải chứa ít nhất một số.\nMật khẩu phải chứa ít nhất một chữ cái viết hoa.\nMật khẩu phải chứa ít nhất một chữ cái viết thường\nMật khẩu phải chứa ít nhất một kí tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không giống nhau !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Mật khẩu nhập lại không thể bỏ trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                    MessageBox.Show("Vui lòng nhập mật khẩu mới !!");
            }
            else
                MessageBox.Show("Mã OTP không xác định !!");
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
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnSendCode.Text = count.ToString();
            count--;
            if (count == 0)
            {
                timer1.Stop();
                btnSendCode.Enabled = true;
                btnSendCode.Text = "";
                btnSendCode.Image = Properties.Resources.mail;
                count = 60;
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public bool CheckPassword(string password)
        {
            string MatchEmailPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,30}$";

            if (password != null) return Regex.IsMatch(password, MatchEmailPattern);
            else return false;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeCode--;
            if (timeCode == 0)
            {
                timer2.Stop();
                timeCode = 5;
            }
                
        }
        private const string mysecurityKey = "CTSOTP12";
        public static string Encrypt(string TextToEncrypt)
        {
            byte[] MyEncryptedArray = UTF8Encoding.UTF8
               .GetBytes(TextToEncrypt);

            MD5CryptoServiceProvider MyMD5CryptoService = new
               MD5CryptoServiceProvider();

            byte[] MysecurityKeyArray = MyMD5CryptoService.ComputeHash
               (UTF8Encoding.UTF8.GetBytes(mysecurityKey));

            MyMD5CryptoService.Clear();

            var MyTripleDESCryptoService = new
               TripleDESCryptoServiceProvider();

            MyTripleDESCryptoService.Key = MysecurityKeyArray;

            MyTripleDESCryptoService.Mode = CipherMode.ECB;

            MyTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = MyTripleDESCryptoService
               .CreateEncryptor();

            byte[] MyresultArray = MyCrytpoTransform
               .TransformFinalBlock(MyEncryptedArray, 0,
               MyEncryptedArray.Length);

            MyTripleDESCryptoService.Clear();

            return Convert.ToBase64String(MyresultArray, 0,
               MyresultArray.Length);
        }
        public static string Decrypt(string TextToDecrypt)
        {
            byte[] MyDecryptArray = Convert.FromBase64String
               (TextToDecrypt);
            MD5CryptoServiceProvider MyMD5CryptoService = new
               MD5CryptoServiceProvider();
            byte[] MysecurityKeyArray = MyMD5CryptoService.ComputeHash
               (UTF8Encoding.UTF8.GetBytes(mysecurityKey));
            MyMD5CryptoService.Clear();
            var MyTripleDESCryptoService = new
               TripleDESCryptoServiceProvider();
            MyTripleDESCryptoService.Key = MysecurityKeyArray;
            MyTripleDESCryptoService.Mode = CipherMode.ECB;
            MyTripleDESCryptoService.Padding = PaddingMode.PKCS7;
            var MyCrytpoTransform = MyTripleDESCryptoService
               .CreateDecryptor();
            byte[] MyresultArray = MyCrytpoTransform
               .TransformFinalBlock(MyDecryptArray, 0,
               MyDecryptArray.Length);
            MyTripleDESCryptoService.Clear();

            return UTF8Encoding.UTF8.GetString(MyresultArray);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordComfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChangePass_Click(this, new EventArgs());
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendCode_Click(this, new EventArgs());
            }
        }
    }
}
