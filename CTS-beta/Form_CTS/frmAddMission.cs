using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using CTS_beta.Models;
using System.Threading;
using System.Configuration;

namespace CTS_beta.Form_CTS
{
    public partial class frmAddMission : Form
    {

        public frmAddMission()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            txtNameMission.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtNameMission.Width, txtNameMission.Height, 10, 10));
            ddlTypeMission.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, ddlTypeMission.Width, ddlTypeMission.Height, 10, 10));
            txtCount.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtCount.Width, txtCount.Height, 10, 10));
            txtExprie.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtExprie.Width, txtExprie.Height, 10, 10));
            txtPoint.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtPoint.Width, txtPoint.Height, 10, 10));
            btnAddNew.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnAddNew.Width, btnAddNew.Height, 10, 10));
            txtDescribe.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtDescribe.Width, txtDescribe.Height, 10, 10));
        }



        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmAddMission_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoadTypeMission()
        {
            var client = new RestClient(ConfigurationSettings.AppSettings["server"]+"/Type_Mission/GetAll");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            List<TypeMission> listTypes = JsonConvert.DeserializeObject<List<TypeMission>>(response.Content.ToString());
            DataTable dt = new DataTable();
            dt.Columns.Add("id_type", typeof(String));
            dt.Columns.Add("name_type_mission", typeof(String));
            foreach (var list in listTypes)
            {
                if(list.status)
                    dt.Rows.Add(list.id_type, list.name_type_mission);
            }
            ddlTypeMission.Invoke(new Action(() =>
            {
                ddlTypeMission.DataSource = dt;
                ddlTypeMission.ValueMember = "id_type";
                ddlTypeMission.DisplayMember = "name_type_mission";
            }
            ));
        }

        //Add a Mission
        private void AddMission()
        {
            if (!txtNameMission.TextName.Equals("") && !txtCount.TextName.Equals("") && !txtPoint.TextName.Equals("") && !txtExprie.TextName.Equals("") && !txtDescribe.Text.Equals(""))
            {
            
                string nameMission = txtNameMission.TextName;
                int idTypeMission = int.Parse(ddlTypeMission.SelectedItem.Value.ToString());
                int count = int.Parse(txtCount.TextName);
                int point = int.Parse(txtPoint.TextName);
                string Stardate = DateTime.Today.ToShortDateString();
                int exprie = int.Parse(txtExprie.TextName);
                string describe = txtDescribe.Text;
                int status = 0;
                int idEmployee = Properties.Settings.Default.id_employee;
                //Mission mission = GetDataFromForm();
                var client = new RestClient(System.Configuration.ConfigurationSettings.AppSettings["server"] +"/Mission/Create?apiKey="+frmUser.Instance.ApiKey);
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddParameter("undefined", "{\"name_mission\":\'" + nameMission + "',\"Stardate\":\'" + Stardate + "',\"point\":" +point + " ,\"exprie\":" + exprie + ",\"describe\":\'" + describe + "',\"status\":\'" + status + "',\"count\":" + count + ",\"id_type\":" + idTypeMission + ",\"id_employee\":" + idEmployee + "}", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                Message obj = JsonConvert.DeserializeObject<Message>(response.Content.ToString());

                MessageBox.Show(obj.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Chưa nhập đủ thông tin");
        }

        private void frmAddMission_Load(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(LoadTypeMission));
            thread.Start();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddMission();
            this.Hide();
        
           
        }
        public class Message
        {
            public string message { get; set; }
        }
    }
}

