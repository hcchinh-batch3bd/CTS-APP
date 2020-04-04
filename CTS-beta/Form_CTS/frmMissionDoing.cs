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
using RestSharp;
using System.Configuration;
using System.Web;

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
            Load:
            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Mission/Missionavailableemp?apiKey=" + HttpUtility.UrlEncode(frmUser.Instance.ApiKey));
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
                if (!radGridView1.InvokeRequired)
                    radGridView1.Rows.Clear();
                else
                    radGridView1.Invoke(new Action(() => radGridView1.Rows.Clear()));
                RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                List<Mission> missionCompletes = obj.results;
                foreach (var mission in missionCompletes)
                {
                    if (!radGridView1.InvokeRequired)
                    {

                        radGridView1.Rows.Add(mission.name_mission, mission.Stardate.AddDays(mission.exprie), mission.name_type_mission, mission.point, "Hoàn thành", mission.id_mission);
                    }
                    else
                        radGridView1.Invoke(new Action(() => radGridView1.Rows.Add(mission.name_mission, mission.Stardate.AddDays(mission.exprie), mission.name_type_mission, mission.point, "Hoàn thành", mission.id_mission)));


                }
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
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hoàn thành không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)                {                    Load:                    int id = int.Parse(e.Row.Cells[5].Value.ToString());
                    var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Mission/" + id + "/CompleteMission?apiKey=" + HttpUtility.UrlEncode(frmUser.Instance.ApiKey));
                    var request = new RestRequest(Method.PUT);
                    IRestResponse response = client.Execute(request);                    if (!response.IsSuccessful)
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
                    {                        MessageBox.Show("Xác nhận hoàn thành nhiệm vụ thành công !!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        radGridView1.Rows.Clear();
                        loadData();                        frmUser.Instance.worker.RunWorkerAsync();                    }                }
                else                {                    this.radGridView1.Rows.Clear();
                    loadData();                }
            }
        }

        private void radGridView1_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "Tacvu")
            {
                e.CellElement.ForeColor = Color.Blue;
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
                e.CellElement.BackColor = Color.Red;
                e.CellElement.Font = new Font(e.CellElement.Font, FontStyle.Underline);
                e.CellElement.DrawFill = true;
            }
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
        }
        public Telerik.WinControls.UI.RadGridView GridView
        {
            get { return radGridView1; }
            set { radGridView1 = value; }
        }
    }
    }
