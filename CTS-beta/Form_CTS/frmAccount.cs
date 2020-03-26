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
    public partial class frmAccount : UserControl
    {
        public frmAccount()
        {
            InitializeComponent();
            this.GridViewAccount.MasterTemplate.EnableGrouping = false;
            this.GridViewAccount.MasterTemplate.AllowDragToGroup = false;
            this.GridViewAccount.MasterTemplate.AutoExpandGroups = false;
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            btnSearch.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 5, 5));
            btnDelete.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 5, 5));
            radTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radTextBox1.Width, radTextBox1.Height, 5, 5));
            button3.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 5, 5));
        }
    
        void LoadData()
        {
            try
            {
                var client = new RestClient(ConfigurationSettings.AppSettings["server"] + "/Account/ListEmployee?apiKey=" + frmAdmin.Instance.ApiKey);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                List<Employee> listAccount = obj.results;
                foreach (var account in listAccount)
                {
                    int old = (DateTime.Now).Year - account.date.Year;
                    if(GridViewAccount.InvokeRequired)
                    {
                        GridViewAccount.Invoke(new Action(() => GridViewAccount.Rows.Add(account.id_employee, account.name_employee, old, account.email, account.point, account.level, account.status)));
                    }
                    else
                        GridViewAccount.Rows.Add(account.id_employee, account.name_employee, old, account.email, account.point, account.level, account.status);
                }
            }
            catch  { };
        }
        public class RootObject
        {
            public List<Employee> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
              if(dialogResult == DialogResult.Yes)
                {
                    int idEmployee = int.Parse(GridViewAccount.Rows[GridViewAccount.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
                    var client = new RestClient(ConfigurationSettings.AppSettings["server"] + "/Account/" + idEmployee + "/DeleteEmployee?apiKey=" + frmAdmin.Instance.ApiKey);
                    var request = new RestRequest(Method.PUT);
                    IRestResponse response = client.Execute(request);
                    try
                    {
                        RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                        MessageBox.Show(obj.message);
                        this.GridViewAccount.Rows.Clear();
                        LoadData();
                    }
                    catch { MessageBox.Show("Server bị mất kết nối"); }
                }
              else
                {
                    this.GridViewAccount.Rows.Clear();
                    LoadData();
                }

            }
            catch { };
        }        

        private void button3_Click(object sender, EventArgs e)
        {
            frmCreateAccount frm = new frmCreateAccount();
            frm.Show();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(LoadData));
            thread.Start();
        }
    }
}
