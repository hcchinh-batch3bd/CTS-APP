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
    public partial class frmMissionAreThere : UserControl
    {
        public frmMissionAreThere()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AutoExpandGroups = false;
            Thread thread = new Thread(new ThreadStart(loadData));
        }
        void loadData()
        {
        Load:
            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Missison/Missionavailable?apiKey=" + frmUser.Instance.ApiKey);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if (!response.IsSuccessful)
            {
                DialogResult dialog = MessageBox.Show("Máy chủ bị mất kết nối !!!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Retry)
                    goto Load;
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                if (!radGridView1.InvokeRequired)
                    radGridView1.Rows.Clear();
                else
                    radGridView1.Invoke(new Action(() => radGridView1.Rows.Clear()));
                RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                List<Mission> missionCompletes = obj.results;
                foreach (var mission in missionCompletes)
                {
                    if (radGridView1.InvokeRequired)
                    {
                        radGridView1.Invoke(new Action(() => radGridView1.Rows.Add(mission.id_mission, mission.name_mission, mission.describe, mission.Stardate, mission.Stardate.AddDays(mission.exprie), mission.name_type_mission, mission.point, "Xem")));
                    }
                    else
                        radGridView1.Rows.Add(mission.id_mission, mission.name_mission, mission.describe, mission.Stardate, mission.Stardate.AddDays(mission.exprie), mission.name_type_mission, mission.point, "Xem");
                }
            }
        }
        class RootObject
        {
            public List<Mission> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }
        private void frmMissionAreThere_load(object sender, EventArgs e)
        {
            loadData();

        }

        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int idMission = int.Parse(e.Row.Cells[0].Value.ToString());

                frmDetailMission f = new frmDetailMission(idMission);
                f.ShowDialog();
            }
        }

        private void radGridView1_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            //   e.Row.Cells[8].Style.BackColor = System.Drawing.Color.Red;
            if (e.CellElement.ColumnInfo.Name == "TacVu")
            {
                e.CellElement.ForeColor = Color.Blue;
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
                e.CellElement.BackColor = Color.Red;
                e.CellElement.Font = new Font(e.CellElement.Font, FontStyle.Underline);
                e.CellElement.DrawFill = true;

            }

        }

        private void radGridView1_Click(object sender, EventArgs e)
        {
        }

        private void radGridView1_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {

        }
        private void PicSyn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(loadData)) { IsBackground = true };
            thread.Start();
            while (thread.IsAlive)
            {
                Application.DoEvents();
                PicSyn.Visible = false;
            }
            PicSyn.Visible = true;
            frmUser.Instance.worker.RunWorkerAsync();
        }
    }
}

