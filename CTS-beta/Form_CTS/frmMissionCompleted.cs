using RestSharp;
using System;
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
using System.Configuration;

namespace CTS_beta.Form_CTS
{
    public partial class frmMissionCompleted : UserControl
    {
        public frmMissionCompleted()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            this.data.MasterTemplate.EnableGrouping = false;
            this.data.MasterTemplate.AllowDragToGroup = false;
            this.data.MasterTemplate.AutoExpandGroups = false;
        }

        private void frmMissionCompleted_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(LoadData));
            thread.Start();
        }
        void LoadData()
        {
            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Mission/ListMissionComplete?apiKey="+Properties.Settings.Default.apiKey);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            try
            {
                if (!data.InvokeRequired)
                    data.Rows.Clear();
                else
                    data.Invoke(new Action(() => data.Rows.Clear()));
                RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                List<MissionComplete> missionCompletes = obj.results;
                foreach (var mission in missionCompletes)
                {
                    if(!data.InvokeRequired)
                        data.Rows.Add(mission.name_mission, mission.date, mission.name_type_mission, mission.point, "Đã hoàn thành");
                    else
                        data.Invoke(new Action(() => data.Rows.Add(mission.name_mission, mission.date, mission.name_type_mission, mission.point, "Đã hoàn thành")));               
                }
            }
           catch
            {
                MessageBox.Show("Máy chủ " + ConfigurationManager.AppSettings["server"] +  "bị mất kết nối");
            }
            
            
        }
        class RootObject
        {
            public List<MissionComplete> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        private void PicSyn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(LoadData)) { IsBackground = true };
            thread.Start();
            while (thread.IsAlive)
            {
                Application.DoEvents();
                PicSyn.Visible = false;
            }
            PicSyn.Visible = true;
        }
        public Telerik.WinControls.UI.RadGridView GridView
        {
            get { return data; }
            set { data = value; }
        }
    }
}
