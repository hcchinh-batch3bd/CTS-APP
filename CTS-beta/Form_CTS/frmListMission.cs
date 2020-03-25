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


namespace CTS_beta.Form_CTS
{
    public partial class frmListMission : Form
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
            var client = new RestClient("https://api.hotrogame.online/Mission/ListMission");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
            List<Mission> mission = obj.results;
            foreach (var item in mission)
            {
                int status = item.status;
                switch(status)
                {
                    case -1:
                        if (!data.InvokeRequired)
                            data.Rows.Add(item.id_mission, item.name_mission, item.id_type, item.describe, item.Count, "Hủy", item.point);
                        else
                            data.Invoke(new Action(() => data.Rows.Add(item.id_mission, item.name_mission, item.id_type, item.describe, item.Count, "Hủy", item.point)));
                        break;
                    case 0:
                        if (!data.InvokeRequired)
                            data.Rows.Add(item.id_mission, item.name_mission, item.id_type, item.describe, item.Count, "Đang duyệt", item.point);
                        else
                            data.Invoke(new Action(() => data.Rows.Add(item.id_mission, item.name_mission, item.id_type, item.describe, item.Count, "Đang duyệt", item.point)));
                        break;
                    default:
                        if (!data.InvokeRequired)
                            data.Rows.Add(item.id_mission, item.name_mission, item.id_type, item.describe, item.Count, "Đang chạy", item.point);
                        else
                            data.Invoke(new Action(() => data.Rows.Add(item.id_mission, item.name_mission, item.id_type, item.describe, item.Count, "Đang chạy", item.point)));
                        break;
                }
                
                
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
            var client = new RestClient("https://api.hotrogame.online/Mission/"+idMission+"/ClearMission?apiKey=admin");
            var request = new RestRequest(Method.PUT);
            IRestResponse response = client.Execute(request);
            data.Rows.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMission();
            LoadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            LoadData();
        }
    }

    class RootObject
        {
            public List<Mission> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

    }