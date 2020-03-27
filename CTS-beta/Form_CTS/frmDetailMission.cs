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

namespace CTS_beta.Form_CTS
{
    public partial class frmDetailMission : Form
    {
        int idMission;
        public frmDetailMission(int id)
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            richTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, richTextBox1.Width, richTextBox1.Height, 5, 5));
            btnNhanNhiemVu.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnNhanNhiemVu.Width, btnNhanNhiemVu.Height, 5, 5));
            pictureBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 5, 5));
            idMission = id;
            MoveControl.ReleaseCapture();
        }
        public frmDetailMission(int id, bool comfirm)
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            richTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, richTextBox1.Width, richTextBox1.Height, 5, 5));
            btnNhanNhiemVu.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnNhanNhiemVu.Width, btnNhanNhiemVu.Height, 5, 5));
            pictureBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 5, 5));
            idMission = id;
            btnNhanNhiemVu.Enabled = false;
            MoveControl.ReleaseCapture();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmDetailMission_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            var client = new RestClient(System.Configuration.ConfigurationSettings.AppSettings["server"] + "/Mission/" + idMission + "/Describe");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
            List<Mission> misssion = obj.results;
            lblNameMission.Text = misssion.SingleOrDefault().name_mission;
            lblTypeMission.Text = misssion.SingleOrDefault().name_type_mission.ToString();
            lblNguoiTao.Text = misssion.SingleOrDefault().name_employee.ToString();
            if (misssion.SingleOrDefault().Count == 0)
                lblSLCon.Text = "Không có giới hạn";
            else
                lblSLCon.Text = misssion.SingleOrDefault().countProcess.ToString();
            lblStartDate.Text = misssion.SingleOrDefault().Stardate.Date.ToString();
            lblEndDate.Text = misssion.SingleOrDefault().Stardate.AddDays(misssion.SingleOrDefault().exprie).ToString();
            lblPoint.Text = misssion.SingleOrDefault().point.ToString();
            richTextBox1.Text = misssion.SingleOrDefault().describe.ToString();
        }

        class RootObject
        {
            public List<Mission> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        private void btnNhanNhiemVu_Click(object sender, EventArgs e)
        { 
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn nhận nhiệm vụ không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var client = new RestClient(System.Configuration.ConfigurationSettings.AppSettings["server"] + "/Mission/" + idMission + "/Order?apiKey=" + frmUser.Instance.ApiKey);
                var request = new RestRequest(Method.POST);
                IRestResponse response = client.Execute(request);
                try
                {
                    MessageBox.Show("Nhận nhiệm vụ thành công!!");
                    this.Close();
                    loadData();
                }
                catch { MessageBox.Show("Server bị mất kết nối"); }
            }
            else
            {
                loadData();
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
