﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTS_beta.Models;
using Newtonsoft.Json;
using System.Threading;
using RestSharp;

namespace CTS_beta.Form_CTS
{
    public partial class frmMissionDoing : UserControl
    {
        public frmMissionDoing()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AutoExpandGroups = false;
        }
        void loadData()
        {
            DateTime date = DateTime.Now;
            var client = new RestClient(System.Configuration.ConfigurationSettings.AppSettings["server"] + "/Mission/Missionavailableemp?apiKey=" + frmUser.Instance.ApiKey);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
            List<Mission> missionCompletes = obj.results;
            foreach (var mission in missionCompletes)
            {
                if (radGridView1.InvokeRequired)
                {
                    radGridView1.Invoke(new Action(() => radGridView1.Rows.Add(mission.name_mission, mission.Stardate.AddDays(mission.exprie), mission.id_type, mission.point, "Hoàn thành",mission.id_mission)));
                }
                else
                    radGridView1.Rows.Add(mission.name_mission, mission.exprie, mission.id_type, mission.point, "Hoàn thành",mission.id_mission);


            }
        }
        class RootObject
        {
            public List<Mission> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        private void frmMissionDoing_Load(Object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(loadData));
            thread.Start();
        }



        private void radGridView1_CellClick_1(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                //int row = e.RowIndex;
                //   radGridView1.Rows.RemoveAt(row);
                //   MessageBox.Show(e.Row.Cells[5].Value.ToString());
            
                    
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hoàn thành không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)                {                    int id = int.Parse(e.Row.Cells[5].Value.ToString());
                    var client = new RestClient(System.Configuration.ConfigurationSettings.AppSettings["server"] + "/Mission/" + id + "/CompleteMission?apiKey=" + frmUser.Instance.ApiKey);
                    var request = new RestRequest(Method.PUT);
                    IRestResponse response = client.Execute(request);                    try                    {                        MessageBox.Show("Nhiệm vụ đã hoàn thành!!");
                        radGridView1.Rows.Clear();
                        loadData();                    }                    catch { MessageBox.Show("Server bị mất kết nối"); }                }
                else                {                    this.radGridView1.Rows.Clear();
                    loadData();                }

                
                    
                


            }
        }
        
    }
    }
