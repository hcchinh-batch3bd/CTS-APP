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
using System.Configuration;
using Newtonsoft.Json;
using CTS_beta.Models;
using System.Threading;
using System.Web;

namespace CTS_beta.Form_CTS
{
    public partial class frmUser : Form
    {
        string apiKey;
        frmLogin frmLogin;
        public frmUser()
        {
            InitializeComponent();
            pictureBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 5, 5));
            txtSearch.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtSearch.Width, txtSearch.Height, 5, 5));
            btnSeach.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnSeach.Width, btnSeach.Height, 5, 5));
            apiKey = Properties.Settings.Default.apiKey;
           
        }
        static frmUser _obj;
        public static frmUser Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmUser();
                }
                return _obj;
            }
        }
        public string ApiKey
        {
            get { return apiKey; }
            set { apiKey = value; }
        }
        public BackgroundWorker worker
        {
            get { return backgroundWorker1; }
            set { backgroundWorker1 = value; }
        }
        public frmUser(frmLogin frm,string apiKey)
        {
            InitializeComponent();
            pictureBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 5, 5));
            txtSearch.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, txtSearch.Width, txtSearch.Height, 5, 5));
            btnSeach.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnSeach.Width, btnSeach.Height, 5, 5));
            this.apiKey = apiKey;
            Properties.Settings.Default.apiKey = apiKey;
            Properties.Settings.Default.Save();
            frmLogin = frm;
        }
        private void btnExitUser_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMissionAreThere_Click(object sender, EventArgs e)
        {
            ChildForm.OpenChildForm(new frmMissionAreThere(), panelDesktop);
        }

        private void btnMissionDoing_Click(object sender, EventArgs e)
        {
            ChildForm.OpenChildForm(new frmMissionDoing(), panelDesktop);
        }

        private void btnMissionCompleted_Click(object sender, EventArgs e)
        {
            ChildForm.OpenChildForm(new frmMissionCompleted(), panelDesktop);
        }

        private void btnCreateMission_Click(object sender, EventArgs e)
        {
            frmAddMission fAdd = new frmAddMission();
            fAdd.Show();
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dosomething()
        {
            Thread thread = new Thread(new ThreadStart(LoadAPP));
            thread.Start();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            frmLoading frm = new frmLoading();
            frm.Show();
            Thread thread = new Thread(new ThreadStart(LoadAPP)) { IsBackground = true };
            thread.Start();
            while(thread.IsAlive)
            {
                Application.DoEvents();
            }
            frm.Close();
        }
        class User
        {
            public int id_employee { get; set; }
            public string name_employee { get; set; }
            public bool level { get; set; }
            public int point { get; set; }
            public int totalProcess { get; set; }
            public int totalComplete { get; set; }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.apiKey = "";
            Properties.Settings.Default.Save();
            if(frmLogin!=null)
            {
                frmLogin.Invalidate();
                frmLogin.Show();
                this.Close();
            }
            else
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }
        }
        void LoadAPP()
        {
            Load:

                var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Account?apiKey=" + HttpUtility.UrlEncode(apiKey));
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

                User obj = JsonConvert.DeserializeObject<User>(response.Content.ToString());
                if (lblPoint.InvokeRequired)
                    lblPoint.Invoke(new Action(() => lblPoint.Text= "Điểm: "+obj.point.ToString()));
                else
                    lblPoint.Text= "Điểm: "+obj.point.ToString();
                if (lblNameEmployee.InvokeRequired)
                    lblNameEmployee.Invoke(new Action(() => lblNameEmployee.Text = "♔ "+obj.name_employee.ToString()+ " ♔"));
                else
                    lblNameEmployee.Text = obj.name_employee.ToString();
                if (lblNameEmployee.InvokeRequired)
                    lblCountComplete.Invoke(new Action(() => lblCountComplete.Text = obj.totalComplete.ToString()));
                else
                    lblCountComplete.Text = obj.totalComplete.ToString();
                if (lblCountProcess.InvokeRequired)
                    lblCountProcess.Invoke(new Action(() => lblCountProcess.Text = obj.totalProcess.ToString()));
                else
                    lblCountProcess.Text = obj.totalProcess.ToString();
                _obj = this;
                client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Missison/Missionavailable?apiKey=" + HttpUtility.UrlEncode(apiKey));
                request = new RestRequest(Method.GET);
                response = client.Execute(request);
                RootObject ob = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                List<Mission> mission = ob.results;
                lblCountAreThere.Invoke(new Action(() => lblCountAreThere.Text = mission.Count().ToString()));
                ChildForm.OpenChildForm(new frmMissionAreThere(), panelDesktop);
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            dosomething();
        }

        private void btnChangePass_Click_1(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                foreach (Control c in panelDesktop.Controls)
                {
                    if(c.ToString().Equals("CTS_beta.Form_CTS.frmMissionAreThere"))
                    {
                        Application.DoEvents();
                        Load:
                        var client = new RestClient(ConfigurationManager.AppSettings["server"]+"/Mission/Search?key=" +txtSearch.Text);
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
                            frmMissionAreThere frm = c as frmMissionAreThere;
                            if (!frm.GridView.InvokeRequired)
                                frm.GridView.Rows.Clear();
                            else
                                frm.GridView.Invoke(new Action(() => frm.GridView.Rows.Clear()));
                            MissionResult obj = JsonConvert.DeserializeObject<MissionResult>(response.Content.ToString());
                            List<Mission> missionCompletes = obj.results;
                            if(missionCompletes!=null)
                            {
                                foreach (var mission in missionCompletes)
                                {
                                    if (frm.GridView.InvokeRequired)
                                    {
                                        frm.GridView.Invoke(new Action(() => frm.GridView.Rows.Add(mission.id_mission, mission.name_mission, mission.describe, mission.Stardate, mission.Stardate.AddDays(mission.exprie), mission.name_type_mission, mission.point, "Xem")));
                                    }
                                    else
                                        frm.GridView.Rows.Add(mission.id_mission, mission.name_mission, mission.describe, mission.Stardate, mission.Stardate.AddDays(mission.exprie), mission.name_type_mission, mission.point, "Xem");
                                }
                            }
                                
                        }

                            break;
                    }
                    if(c.ToString().Equals("CTS_beta.Form_CTS.frmMissionDoing"))
                    {
                        Application.DoEvents();
                    Load:
                        var client = new RestClient(ConfigurationManager.AppSettings["server"]+ "/Mission/Missionavailableemp/Search?key=" + txtSearch.Text+"&apiKey="+ HttpUtility.UrlEncode(apiKey));
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
                            frmMissionDoing frm = c as frmMissionDoing;
                            if (!frm.GridView.InvokeRequired)
                                frm.GridView.Rows.Clear();
                            else
                                frm.GridView.Invoke(new Action(() => frm.GridView.Rows.Clear()));
                            MissionResult obj = JsonConvert.DeserializeObject<MissionResult>(response.Content.ToString());
                            List<Mission> missionCompletes = obj.results;
                            if (missionCompletes != null)
                            {
                                foreach (var mission in missionCompletes)
                                {
                                    if (!frm.GridView.InvokeRequired)
                                    {

                                        frm.GridView.Rows.Add(mission.name_mission, mission.Stardate.AddDays(mission.exprie), mission.name_type_mission, mission.point, "Hoàn thành", mission.id_mission);
                                    }
                                    else
                                        frm.GridView.Invoke(new Action(() => frm.GridView.Rows.Add(mission.name_mission, mission.Stardate.AddDays(mission.exprie), mission.name_type_mission, mission.point, "Hoàn thành", mission.id_mission)));


                                }
                            }

                        }

                        break;
                    }
                    if(c.ToString().Equals("CTS_beta.Form_CTS.frmMissionCompleted"))
                    {
                        Application.DoEvents();
                    Load:
                        var client = new RestClient(ConfigurationManager.AppSettings["server"]+ "/Mission/ListMissionComplete/Search?key=" + txtSearch.Text+"&apiKey="+ HttpUtility.UrlEncode(apiKey));
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
                            frmMissionCompleted frm = c as frmMissionCompleted;
                            if (!frm.GridView.InvokeRequired)
                                frm.GridView.Rows.Clear();
                            else
                                frm.GridView.Invoke(new Action(() => frm.GridView.Rows.Clear()));
                            MissionCompltetResult obj = JsonConvert.DeserializeObject<MissionCompltetResult>(response.Content.ToString());
                            List<MissionComplete> missionCompletes = obj.results;
                            if (missionCompletes != null)
                            {
                                foreach (var mission in missionCompletes)
                                {
                                    if (!frm.GridView.InvokeRequired)
                                        frm.GridView.Rows.Add(mission.name_mission, mission.date, mission.name_type_mission, mission.point, "Đã hoàn thành");
                                    else
                                        frm.GridView.Invoke(new Action(() => frm.GridView.Rows.Add(mission.name_mission, mission.date, mission.name_type_mission, mission.point, "Đã hoàn thành")));
                                }
                            }

                        }

                        break;
                    }
                }
            }
            else
                MessageBox.Show("Bạn cần nhập tên hoặc mô tả vào !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        class MissionResult
        {
            public List<Mission> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }
        class MissionCompltetResult
        {
            public List<MissionComplete> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void btnSeach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSeach_Click(this, new EventArgs());
            }
        }
    }
}
