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

namespace CTS_beta.Form_CTS
{
    public partial class frmUser : Form
    {
        string apiKey;
        frmLogin frmLogin;
        public frmUser()
        {
            InitializeComponent();
            ChildForm.OpenChildForm(new frmMissionAreThere(), panelDesktop);
            radTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radTextBox1.Width, radTextBox1.Height, 5, 5));
            pictureBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 5, 5));
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
            ChildForm.OpenChildForm(new frmMissionAreThere(), panelDesktop);
            radTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radTextBox1.Width, radTextBox1.Height, 5, 5));
            pictureBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 5, 5));
            this.apiKey = apiKey;
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
            this.Visible = false;
            frmLoading frm = new frmLoading();
            frm.Show();
            Thread thread = new Thread(new ThreadStart(LoadAPP)) { IsBackground = true };
            thread.Start();
            while(thread.IsAlive)
            {
                Application.DoEvents();
            }
            frm.Close();
            this.Visible = true;
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
            Properties.Settings.Default.id_employee = 0;
            Properties.Settings.Default.Save();
            if(frmLogin!=null)
            {
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
            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Account?apiKey=" + apiKey);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            User obj = JsonConvert.DeserializeObject<User>(response.Content.ToString());
            lblPoint.Invoke(new Action(()=>lblPoint.Text = obj.point.ToString()));
            lblNameEmployee.Invoke(new Action(()=>lblNameEmployee.Text = obj.name_employee.ToString()));
            lblCountComplete.Invoke(new Action(()=>lblCountComplete.Text = obj.totalComplete.ToString()));
            lblCountProcess.Invoke(new Action(()=>lblCountProcess.Text = obj.totalProcess.ToString()));
            Properties.Settings.Default.id_employee = obj.id_employee;
            Properties.Settings.Default.Save();
            _obj = this;
            client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Missison/Missionavailable?apiKey=" + frmUser.Instance.ApiKey);
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            RootObject ob = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
            List<Mission> mission = ob.results;
            lblCountAreThere.Invoke(new Action(()=>lblCountAreThere.Text = mission.Count().ToString()));
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            dosomething();
        }
    }
}
