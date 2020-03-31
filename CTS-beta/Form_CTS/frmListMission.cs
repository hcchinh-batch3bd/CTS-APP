using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;
using CTS_beta.Models;
using RestSharp;
using System.Configuration;

namespace CTS_beta.Form_CTS
{
    public partial class frmListMission : UserControl
    {
        public frmListMission()
        {
            InitializeComponent();
            this.data.MasterTemplate.EnableGrouping = false;
            this.data.MasterTemplate.AllowDragToGroup = false;
            this.data.MasterTemplate.AutoExpandGroups = false;
        }

        private void frmListMission_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            button1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 5, 5));
            btnAddMission.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnAddMission.Width, btnAddMission.Height, 5, 5));
            Thread thread = new Thread(new ThreadStart(LoadData));
            thread.Start();
        }

        private void LoadData()
        {
            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Mission/ListMission");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            try
            {
                RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                List<Mission> mission = obj.results;
                foreach (var item in mission)
                {
                    string Count = "";
                    if (item.Count == 0)
                        Count = "Không giới hạn";
                    else
                        Count = item.Count.ToString();
                    int status = item.status;
                    switch (status)
                    {
                        case -1:
                            if (!data.InvokeRequired)
                                data.Rows.Add(item.id_mission, item.name_mission, item.id_type, item.describe, Count, "Hủy", item.point);
                            else
                                data.Invoke(new Action(() => data.Rows.Add(item.id_mission, item.name_mission, item.name_type_mission, item.describe, Count, "Hủy", item.point)));
                            break;
                        case 0:
                            if (!data.InvokeRequired)
                                data.Rows.Add(item.id_mission, item.name_mission, item.name_type_mission, item.describe, Count, "Đang duyệt", item.point);
                            else
                                data.Invoke(new Action(() => data.Rows.Add(item.id_mission, item.name_mission, item.name_type_mission, item.describe, Count, "Đang duyệt", item.point)));
                            break;
                        default:
                            if (!data.InvokeRequired)
                                data.Rows.Add(item.id_mission, item.name_mission, item.id_type, item.describe, Count, "Đang chạy", item.point);
                            else
                                data.Invoke(new Action(() => data.Rows.Add(item.id_mission, item.name_mission, item.name_type_mission, item.describe, Count, "Đang chạy", item.point)));
                            break;
                    }


                }
            }
            catch
            {
                MessageBox.Show("Máy chủ " + ConfigurationManager.AppSettings["server"] + " không thể kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddMission_Click(object sender, EventArgs e)
        {
            frmAddMission fAdd = new frmAddMission();
            fAdd.Show();

        }

        private void DeleteMission()
        {
            int idMission = int.Parse(data.Rows[data.CurrentCell.RowIndex].Cells["id"].Value.ToString());
            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Mission/" +idMission+"/ClearMission?apiKey="+Properties.Settings.Default.apiKey);
            var request = new RestRequest(Method.PUT);
            IRestResponse response = client.Execute(request);
            data.Rows.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string statuss = (data.Rows[data.CurrentCell.RowIndex].Cells["status"].Value.ToString());
            if (!statuss.Equals("Hủy"))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteMission();
                    LoadData();
                }
            }
            else
                MessageBox.Show("Nhiệm vụ đã dừng hoạt động !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PicSyn_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
            Thread thread = new Thread(new ThreadStart(LoadData));
            thread.Start();
        }
    }

    class RootObject
        {
            public List<Mission> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

    }