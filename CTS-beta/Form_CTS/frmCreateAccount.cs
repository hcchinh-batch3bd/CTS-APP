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

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn tạo không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {                
                var client = new RestClient(ConfigurationSettings.AppSettings["server"] + "/Employee/Create?apiKey=" + frmAdmin.Instance.ApiKey);
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                Employee employee = new Employee();
                employee.name_employee = txtname_employee.Text;
                employee.email = txtemail.Text;
                employee.password = txtpassword.Text;
                employee.date = txtdate.Value.Date;
                bool levels;
                if (txtlevel.SelectedText=="Quản lý")
                {
                    levels = true;
                }
                else { levels = false; }
                  employee.level = levels.ToString();
                string output = JsonConvert.SerializeObject(employee);
                request.AddParameter("application/json", output, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                // request.AddParameter("undefined", "{\"name_employee\":\'" + txtname_employee.Text + "',\"date\":\'" + txtdate.Text + "',\"email\":" + txtemail.Text + " ,\"password\":" + txtpassword.Text + ",\"level_employee\":\'" + txtlevel.ValueMember + "' }", ParameterType.RequestBody);
                RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                MessageBox.Show(obj.message);
                //Thread thread = new Thread(new ThreadStart(LoadData));
                //thread.Start();                
                // MessageBox.Show(obj.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {

           
        }
        public class RootObject
        {
            public List<Employee> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }


    }
}
