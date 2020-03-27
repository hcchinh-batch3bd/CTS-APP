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
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Configuration;

namespace CTS_beta.Form_CTS
{
    public partial class frmTypeMission : UserControl
    {
        private List<TypeMission> typeMissions;

        public frmTypeMission()
        {
            InitializeComponent();
            this.data.MasterTemplate.EnableGrouping = false;
            this.data.MasterTemplate.AllowDragToGroup = false;
            this.data.MasterTemplate.AutoExpandGroups = false;
        }

        private void frmTypeMission_Load(object sender, EventArgs e)
        {
            data.Rows.Clear();
            Thread thread = new Thread(new ThreadStart(LoadData));
            thread.Start();
        }
        private bool check(string name)
        {
            foreach (var type in typeMissions)
            {
                if (type.name_type_mission.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        private void radLabel1_Click(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            var typeMission = new RestClient(ConfigurationSettings.AppSettings["server"] +"/Type_Mission/GetAll");
            var request = new RestRequest(Method.GET);
            IRestResponse response = typeMission.Execute(request);
            typeMissions = JsonConvert.DeserializeObject<List<TypeMission>>(response.Content.ToString());

            foreach (var type in typeMissions)
            {
                if (type.status.Equals(true))

                    if (!data.InvokeRequired)
                    {

                        data.Rows.Add(type.id_type, type.name_type_mission, "Đang hoạt động");
                    }
                    else
                        data.Invoke(new Action(() => data.Rows.Add(type.id_type, type.name_type_mission, "Đang hoạt động")));
                else
                     if (!data.InvokeRequired)
                {

                    data.Rows.Add(type.id_type, type.name_type_mission, "Dừng hoạt động");
                }
                else
                    data.Invoke(new Action(() => data.Rows.Add(type.id_type, type.name_type_mission, "Dừng hoạt động")));
            }
        }


        private void jTextBox1_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            btnAdd.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));
            btnDel.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnDel.Width, btnDel.Height, 10, 10));
            btnEdit.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnDel.Width, btnDel.Height, 10, 10));
            txtaddnametypemisson.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtaddnametypemisson.Width, txtaddnametypemisson.Height, 5, 5));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        class RootObject
        {
            public List<TypeMission> results { get; set; }
            public int id_type { get; set; }
            public string name_type_mission { get; set; }
            public int id_employee { get; set; }
            public Boolean status { get; set; }
            public DateTime date { get; set; }
            public string message { get; set; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var nameType = txtaddnametypemisson.TextName;
            if (nameType != "")
            {
                if (!check(txtaddnametypemisson.TextName))
                {

                    var client = new RestClient(ConfigurationSettings.AppSettings["server"]+ "/Type_Mission/Create?apiKey="+Properties.Settings.Default.apiKey);
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("content-type", "application/json");
                    TypeMission typeMission = new TypeMission();
                    typeMission.name_type_mission = txtaddnametypemisson.TextName;
                    typeMission.id_employee = 189212;
                    typeMission.status = true;
                    typeMission.date = DateTime.Now;
                    string output = JsonConvert.SerializeObject(typeMission);
                    request.AddParameter("application/json", output, ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                    RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                    MessageBox.Show(obj.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread thread = new Thread(new ThreadStart(LoadData));
                    thread.Start();
                    txtaddnametypemisson.TextName = "";
                }

                else
                {
                    MessageBox.Show("Tên loại nhiệm vụ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtaddnametypemisson.TextName = "";
                }
            }
            else MessageBox.Show("Bạn chưa nhập tên loại nhiệm vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = data.Rows[data.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            var client = new RestClient(ConfigurationSettings.AppSettings["server"] + "/Type_Mission/Edit?apiKey="+Properties.Settings.Default.apiKey);
            var request = new RestRequest(Method.PUT);
            request.AddHeader("content-type", "application/json");
            TypeMission typeMission = new TypeMission();
            typeMission.id_type = int.Parse(id.ToString());

            if (data.Rows[data.CurrentCell.RowIndex].Cells["nameType"].Value != null)
            {
                typeMission.name_type_mission = data.Rows[data.CurrentCell.RowIndex].Cells["nameType"].Value.ToString();
                typeMission.id_employee = 189212;
                typeMission.status = true;
                typeMission.date = DateTime.Now;
                string output = JsonConvert.SerializeObject(typeMission);
                request.AddParameter("application/json", output, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                MessageBox.Show(response.Content.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data.Rows.Clear();
                LoadData();
                btnEdit.Enabled = false;
            }
            else MessageBox.Show("Bạn chưa nhập tên loại nhiệm vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data.Rows.Clear();
            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string statuss = (data.Rows[data.CurrentCell.RowIndex].Cells["Status"].Value.ToString());

            if (statuss.Equals("Đang hoạt động"))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(data.Rows[data.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
                    var client = new RestClient(ConfigurationSettings.AppSettings["server"] +"/Type_Mission/" + id + "/Remove?apiKey="+Properties.Settings.Default.apiKey);
                    var request = new RestRequest(Method.PUT);
                    data.Rows.Clear();
                    IRestResponse response = client.Execute(request);
                    RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                    MessageBox.Show(obj.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread thread = new Thread(new ThreadStart(LoadData));
                    thread.Start();
                }

            }
            else MessageBox.Show("Tài khoản này đã dừng hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void data_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
        }

        private void data_Click(object sender, EventArgs e)
        {
            if (data.Rows[data.CurrentCell.RowIndex].Cells["Status"].Value.ToString().Equals("Dừng hoạt động"))
            {
                data.Rows[data.CurrentCell.RowIndex].Cells["nameType"].ReadOnly = true;

            }
        }

        private void PicSyn_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
            Thread thread = new Thread(new ThreadStart(LoadData));
            thread.Start();
        }
    }
}
