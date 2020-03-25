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
            var client = new RestClient(System.Configuration.ConfigurationSettings.AppSettings["server"]+"/Mission/ListMissionComplete?apiKey="+frmUser.Instance.ApiKey);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            RootObject obj= JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
            List<MissionComplete> missionCompletes = obj.results;
            foreach(var mission in missionCompletes)
            {
                data.Rows.Add(mission.name_mission, mission.date, mission.id_type, mission.point, "Đã hoàn thành");
                //data.Invoke(new Action(() => data.Rows.Add(mission.name_mission, mission.date, mission.id_type, mission.point, "Đã hoàn thành")));               
            }
            
            
        }
        class RootObject
        {
            public List<MissionComplete> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }
    }
}
