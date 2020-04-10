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
using System.Text.RegularExpressions;
using System.Web;
using System.Threading;
using System.Security.Cryptography;

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
            frmForgotPassword fForgotPass = new frmForgotPassword(this);
            fForgotPass.Show();
            this.Hide();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        Load:
            if (txtID.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Vui lòng không được bỏ trống !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                if (CheckID(txtID.Text) && txtID.Text.Length==6)
                {
                    if (ckbRemember.Checked)
                    {
                        Properties.Settings.Default.id_employee = int.Parse(txtID.Text);
                        Properties.Settings.Default.password = Encrypt(txtPassword.Text);
                        Properties.Settings.Default.Save();
                    }
                        string ID = HttpUtility.UrlEncode(txtID.Text);
                    radWaitingBar1.Refresh();
                    radWaitingBar1.Visible = true;
                    radWaitingBar1.StartWaiting();
                    IRestResponse response = null;
                    Thread t = new Thread(() =>
                     {
                         string Password = HttpUtility.UrlEncode(txtPassword.Text);
                         var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Account/CheckLogin?id=" + ID + "&pw=" + Password);
                         var request = new RestRequest(Method.GET);
                         response = client.Execute(request);
                     })
                    { IsBackground = true };
                    t.Start();
                    while(t.IsAlive)
                    {
                        Application.DoEvents();
                        btnLogin.Enabled = false;
                    }
                    radWaitingBar1.StopWaiting();
                    radWaitingBar1.Visible = false;
                    btnLogin.Enabled = true;
                    if (!response.IsSuccessful)
                    {
                        DialogResult dialog = MessageBox.Show("☠ Máy chủ bị mất kết nối !!!", "☠ Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (dialog == DialogResult.Retry)
                            goto Load;
                        Application.Exit();
                    }
                    else
                    {

                        RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                        List<Session> sessions = obj.results;
                        if (sessions.Count>0)
                        {
                            MessageBox.Show("❀ Chào mừng bạn đến với hệ thống ❀ \n❤ Chúc một ngày tốt lành ❤ ", "♔ Thông báo ♔ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Properties.Settings.Default.id_employee = sessions.FirstOrDefault().id_employee;
                            if (ckbRemember.Checked)
                            {
                                Properties.Settings.Default.apiKey = sessions.FirstOrDefault().apiKey;
                                Properties.Settings.Default.id_employee = int.Parse(txtID.Text);
                                Properties.Settings.Default.password = Encrypt(txtPassword.Text);
                                Properties.Settings.Default.level = sessions.FirstOrDefault().level_employee;
                                Properties.Settings.Default.Save();
                                txtID.Text = Properties.Settings.Default.id_employee.ToString();
                                txtPassword.Text = Properties.Settings.Default.password;
                                ckbRemember.Checked = false;
                            }
                            else
                            {
                                if(Properties.Settings.Default.id_employee==0 || Properties.Settings.Default.password=="")
                                {
                                    txtID.Text = "";
                                    txtPassword.Text = "";
                                    ckbRemember.Checked = false;
                                }
                                
                            }
                            Properties.Settings.Default.level = sessions.FirstOrDefault().level_employee;
                            Properties.Settings.Default.Save();
                            if (sessions.FirstOrDefault().level_employee)
                            {
                                frmAdmin frmAdmin = new frmAdmin(this, sessions.FirstOrDefault().apiKey);
                                this.Hide();
                                frmAdmin.Show();
                            }
                            else
                            {
                                frmUser frmUser = new frmUser(this, sessions.FirstOrDefault().apiKey);
                                this.Hide();
                                frmUser.Show();

                            }
                        }
                        else
                            MessageBox.Show(obj.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Mã đăng nhập phải là số và có độ dài bằng 6", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.id_employee>0 && Properties.Settings.Default.password!="")
            {
                txtID.Text = Properties.Settings.Default.id_employee.ToString();
                txtPassword.Text = Decrypt(Properties.Settings.Default.password);
            }
        }
        public bool CheckID(string id)
        {
            string MatchEmailPattern = "^[0-9]+$";
            if (id != null) return Regex.IsMatch(id, MatchEmailPattern);
            else return false;
        }

        private void ckbRemember_CheckStateChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
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
            TextToDecrypt = TextToDecrypt.Replace(" ", "+");
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
        private const string mysecurityKey = "CTSOTP12";
    }
}
