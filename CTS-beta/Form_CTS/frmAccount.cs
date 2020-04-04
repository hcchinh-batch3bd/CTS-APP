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
            btnDelete.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 5, 5));
            button3.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 5, 5));
        }

        void LoadData()
        {
        Load:
            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Account/ListEmployee?apiKey=" + Properties.Settings.Default.apiKey);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
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
                RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                List<Employee> listAccount = obj.Results;
                foreach (var account in listAccount)
                {
                    int old = (DateTime.Now).Year - account.date.Year;
                    if (GridViewAccount.InvokeRequired)
                    {
                        GridViewAccount.Invoke(new Action(() => GridViewAccount.Rows.Add(account.id_employee, account.name_employee, old, account.email, account.point, account.level, account.status)));
                    }
                    else
                        GridViewAccount.Rows.Add(account.id_employee, account.name_employee, old, account.email, account.point, account.level, account.status);
                }

            }
        }
        public class RootObject
        {
            public List<Employee> Results { get; set; }
            public bool Status { get; set; }
            public string Message { get; set; }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if ((!GridViewAccount.Rows[GridViewAccount.CurrentCell.RowIndex].Cells["status"].Value.ToString().Equals("Nghỉ việc")))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Load:
                        int idEmployee = int.Parse(GridViewAccount.Rows[GridViewAccount.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
                        var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Account/" + idEmployee + "/DeleteEmployee?apiKey=" + Properties.Settings.Default.apiKey);
                        var request = new RestRequest(Method.PUT);
                        IRestResponse response = client.Execute(request);
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
                            RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                            MessageBox.Show(obj.Message);
                            this.GridViewAccount.Rows.Clear();
                            LoadData();
                        }
                    }
                    else
                    {
                        this.GridViewAccount.Rows.Clear();
                        LoadData();
                    }

                }
                catch { };
            }
            else
                MessageBox.Show("Tài khoản đã bị xóa, không thể xóa lần nữa !!");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmCreateAccount frm = new frmCreateAccount();
            frm.ShowDialog();
            GridViewAccount.Rows.Clear();
            Thread thread = new Thread(new ThreadStart(LoadData)) { IsBackground = true };
            thread.Start();
            while (thread.IsAlive)
            {
                Application.DoEvents();
                PicSyn.Visible = false;
            }
            PicSyn.Visible = true;
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(LoadData));
            thread.Start();
        }

        private void PicSyn_Click(object sender, EventArgs e)
        {
            GridViewAccount.Rows.Clear();
            Thread thread = new Thread(new ThreadStart(LoadData)) { IsBackground = true };
            thread.Start();
            while (thread.IsAlive)
            {
                Application.DoEvents();
                PicSyn.Visible = false;
            }
            PicSyn.Visible = true;
        }
    }
}
