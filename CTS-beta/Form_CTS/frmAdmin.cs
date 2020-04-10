using CTS_beta.Form_CTS;
using CTS_beta.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CTS_beta
{
    public partial class frmAdmin : Telerik.WinControls.UI.RadForm
    {
        int numNotify=0;
        frmLogin frmLogin;
        public frmAdmin()
        {
            InitializeComponent();
            
        }
        public frmAdmin(frmLogin frm, string apiKey)
        {
            InitializeComponent();
            Properties.Settings.Default.apiKey = apiKey;
            Properties.Settings.Default.Save();
            panel5.AutoScroll = true;
            frmLogin = frm;
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống hay không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result== DialogResult.Yes)
            {
                if(frmLogin!=null)
                {
                    Properties.Settings.Default.apiKey = "";
                    Properties.Settings.Default.Save();
                    frmLogin.Show();
                    this.Hide();
                }
                else
                {
                    Properties.Settings.Default.apiKey = "";
                    Properties.Settings.Default.Save();
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Hide();
                }
            }
            else
            {
                Application.Exit();
            }
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            ChildForm.OpenChildForm(new frmStatistical(), panel4);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            ChildForm.OpenChildForm(new frmListMission(), panel4);
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            ChildForm.OpenChildForm(new frmTypeMission(), panel4);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            ChildForm.OpenChildForm(new frmAccount(), panel4);
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            frmLoading frm = new frmLoading();
            frm.Show();
            Thread thread = new Thread(new ThreadStart(LoadAPP)) { IsBackground = true };
            thread.Start();
            while (thread.IsAlive)
            {
                Application.DoEvents();
            }
            frm.Close();
            
        }
        void LoadAPP()
        {
            loadNotify();
            ChildForm.OpenChildForm(new frmStatistical(), panel4);
            ShowMenu.customizeDesing(panel5);
            button11.Number = numNotify;
        }
        private void frmAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (panel5.Visible)
            {
                panel5.Visible = false;
            }
                
            else
                panel5.Visible = true;
            
            Thread thread = new Thread(new ThreadStart(loadNotify));
            thread.Start();
        }
        void loadNotify()
        {
        Load:
            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Mission/ListMission");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var clientMissionProcess = new RestClient(ConfigurationManager.AppSettings["server"] + "/MissionProcess?apiKey="+Properties.Settings.Default.apiKey);
            var requestMissionPrcess = new RestRequest(Method.GET);
            IRestResponse responseMissionProcess = clientMissionProcess.Execute(requestMissionPrcess);
            if (!response.IsSuccessful || !responseMissionProcess.IsSuccessful)
            {
                DialogResult dialog = MessageBox.Show("☠ Máy chủ bị mất kết nối !!!", "☠ Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Retry)
                    goto Load;
                else
                {
                    Properties.Settings.Default.apiKey = "";
                    Properties.Settings.Default.Save();
                    Application.Exit();
                }
            }
            else
            {
                if (!panel5.InvokeRequired)
                    panel5.Controls.Clear();
                else
                    panel5.Invoke(new Action(() => panel5.Controls.Clear()));
                RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                List<Mission> mission = obj.results;
                numNotify = 0;
                foreach (var item in mission)
                {
                    if (item.status == 0)
                    {
                        numNotify++;

                        string content = item.name_employee + " đã yêu cầu tạo nhiệm vụ: \"" + item.name_mission + "\"";
                        MissionApproval childForm = new MissionApproval(item.id_mission, content, panel5, true, 0);
                        if (!panel5.InvokeRequired)
                            panel5.Controls.Add(childForm);
                        else
                            panel5.Invoke(new Action(() => panel5.Controls.Add(childForm)));

                        if (childForm.InvokeRequired)
                        {
                            childForm.Invoke(new Action(() => childForm.BringToFront()));
                            childForm.Invoke(new Action(() => childForm.Show()));
                        }
                        else
                        {
                            childForm.BringToFront();

                            childForm.Show();
                        }
                    }
                }
                ObjMissionProcess objMissionPrcess = JsonConvert.DeserializeObject<ObjMissionProcess>(responseMissionProcess.Content.ToString());
                List<MissionProcess> missionProcess = objMissionPrcess.results;
                foreach (var item in missionProcess)
                {
                        numNotify++;

                        string content = item.name_employee + " đã yêu cầu nhận lại nhiệm vụ: \"" + item.name_mission + "\"";
                        MissionApproval childForm = new MissionApproval(item.id, content, panel5, false, item.id_mission);
                        if (!panel5.InvokeRequired)
                            panel5.Controls.Add(childForm);
                        else
                            panel5.Invoke(new Action(() => panel5.Controls.Add(childForm)));

                        if (childForm.InvokeRequired)
                        {
                            childForm.Invoke(new Action(() => childForm.BringToFront()));
                            childForm.Invoke(new Action(() => childForm.Show()));
                        }
                        else
                        {
                            childForm.BringToFront();

                            childForm.Show();
                        }
                }
                button11.Number = numNotify;

            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        class ObjMissionProcess
        {
            public List<MissionProcess> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }
    }
}
