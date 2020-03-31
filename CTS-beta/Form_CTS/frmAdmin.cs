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
        frmLogin frmLogin;
        int num = 0;
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
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.apiKey = "";
            Properties.Settings.Default.id_employee = 0;
            Properties.Settings.Default.Save();
            if (frmLogin != null)
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

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            ChildForm.OpenChildForm(new frmStatistical(), panel4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            ChildForm.OpenChildForm(new frmListMission(), panel4);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            ChildForm.OpenChildForm(new frmTypeMission(), panel4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            ChildForm.OpenChildForm(new frmAccount(), panel4);
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            ChildForm.OpenChildForm(new frmStatistical(), panel4);
            ShowMenu.customizeDesing(panel5);
            button11.Number = num;
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
                panel5.Visible = false;
            else
                panel5.Visible = true;
            panel5.Controls.Clear();
            Thread thread = new Thread(new ThreadStart(loadNotify));
            thread.Start();
        }
        void loadNotify()
        {
            num = 0;
            var client = new RestClient(ConfigurationSettings.AppSettings["server"] + "/Mission/ListMission");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            try
            {
                RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                List<Mission> mission = obj.results;
                
                foreach (var item in mission)
                {
                    if (item.status == 0)
                    {
                        num++;

                        string content = item.name_employee+" đã yêu cầu tạo nhiệm vụ: \""+item.name_mission+"\"";
                        MissionApproval childForm = new MissionApproval(item.id_mission, content,panel5);
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
                button11.Number = num;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Máy chủ "+ex.Message + ConfigurationSettings.AppSettings["server"] + " không thể kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pevent)
        {
            
        }

        private void button11_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //base.DrawImageAndText(graphics, controlState, imageTextRect);
            if (num == 0) return;
            int height = 25;
            var rect = new Rectangle(this.Width - (height), (this.Height - height) / 2, height, height);
            graphics.FillEllipse(Brushes.OrangeRed, rect);
            graphics.DrawEllipse(new Pen(Color.Orange, 2), rect);
            string text = num.ToString();
            SizeF textsize = graphics.MeasureString(text, Font);
            graphics.DrawString(text, Font, Brushes.White, rect.X + ((height - textsize.Width) / 2), rect.Y + ((height - textsize.Height) / 2));
        }
    }
}
