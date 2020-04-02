using CTS_beta.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS_beta.Form_CTS
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            btnCreateAccount.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnCreateAccount.Width, btnCreateAccount.Height, 5, 5));
            txtname_employee.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtname_employee.Width, txtname_employee.Height, 5, 5));
            txtdate.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtdate.Width, txtdate.Height, 5, 5));
            txtpassword.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtpassword.Width, txtpassword.Height, 5, 5));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmCreateAccount_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (!this.txtemail.Text.Contains('@') || !this.txtemail.Text.Contains('.'))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtname_employee.Text != "" && txtpassword.Text != "")
                {
                    if (txtname_employee.Text.Length <= 50 && CheckName(txtname_employee.Text))
                        if (CheckPassword(txtpassword.Text))
                        {
                            if (txtlevel.SelectedValue != null)
                            {

                                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn tạo không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (dialogResult == DialogResult.Yes)
                                {
                                Load:
                                    var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Employee/Create?apiKey=" + Properties.Settings.Default.apiKey);
                                    var request = new RestRequest(Method.POST);
                                    request.AddHeader("content-type", "application/json");
                                    Employee employee = new Employee();
                                    employee.name_employee = txtname_employee.Text;
                                    employee.email = txtemail.Text.ToLower();
                                    employee.password = txtpassword.Text;
                                    employee.date = txtdate.Value.Date;
                                    employee.level_employee = txtlevel.SelectedValue.ToString();
                                    string output = JsonConvert.SerializeObject(employee);
                                    request.AddParameter("application/json", output, ParameterType.RequestBody);
                                    IRestResponse response = client.Execute(request);
                                    if (!response.IsSuccessful)
                                    {
                                        DialogResult dialog = MessageBox.Show("Máy chủ bị mất kết nối !!!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                        if (dialog == DialogResult.Retry)
                                            goto Load;
                                        else
                                        {
                                            Properties.Settings.Default.apiKey = "";
                                            Properties.Settings.Default.id_employee = 0;
                                            Properties.Settings.Default.Save();
                                            Application.Exit();
                                        }
                                    }
                                    else
                                    {
                                        RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                                        MessageBox.Show(obj.message);
                                        if (obj.status)
                                            this.Close();
                                    }
                                }
                            }
                            else
                                MessageBox.Show("Bạn phải chọn chức vụ đang có trên hệ thống !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Mật khẩu phải dài từ 8 đến 30 ký tự.\nMật phải chứa ít nhất một số.\nMật khẩu phải chứa ít nhất một chữ cái viết hoa.\nMật khẩu phải chứa ít nhất một chữ cái viết thường\nMật khẩu phải chứa ít nhất một kí tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Tên nhân viên phải toàn là chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("level");
            dt.Columns.Add("name_level");
            dt.Rows.Add(true, "Quản lý");
            dt.Rows.Add(false, "Nhân viên");
            txtlevel.DataSource = dt;
            txtlevel.DisplayMember = "name_level";
            txtlevel.ValueMember = "level";

        }
        public class RootObject
        {
            public List<Employee> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        private void txtlevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool CheckPassword(string password)
        {
            string Pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,30}$";
            if (password != null) return Regex.IsMatch(password, Pattern);
            else return false;
        }
        public bool CheckName(string name)
        {
            string Pattern = "[a-zA-Z]";
            if (name != null) return Regex.IsMatch(name, Pattern);
            else return false;
        }
    }
}
