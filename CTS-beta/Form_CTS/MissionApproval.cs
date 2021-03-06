﻿using Newtonsoft.Json;
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
using System.Web;

namespace CTS_beta.Form_CTS
{
    public partial class MissionApproval : UserControl
    {
        int id;
        Panel main;
        bool mission;
        int idProcess;
        public MissionApproval(int id, string content, Panel panel, bool Mission, int idProcess)
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            btnAccept.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnAccept.Width, btnAccept.Height, 5, 5));
            btnClose.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnClose.Width, btnClose.Height, 5, 5));
            this.id = id;
            lblContent.Text = content;
            main = panel;
            mission = Mission;
            this.idProcess = idProcess;
        }

        private void lblContent_Click(object sender, EventArgs e)
        {

            if(mission)
            {
                frmDetailMission frmDetailMission = new frmDetailMission(id, true);
                frmDetailMission.ShowDialog();
            }
            else
            {
                frmDetailMission frmDetailMission = new frmDetailMission(idProcess, true);
                frmDetailMission.ShowDialog();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(mission)
            {
            Load:
                var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Mission/" + id + "/Confirm?apiKey=" + HttpUtility.UrlEncode(Properties.Settings.Default.apiKey));
                var request = new RestRequest(Method.PUT);
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
                    Message obj = JsonConvert.DeserializeObject<Message>(response.Content.ToString());
                    MessageBox.Show(obj.message);
                    main.Visible = false;
                    this.Refresh();
                }
            }
            else
            {
            Load:
                var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/MissionOrder/" + id + "/Confirm?apiKey=" + HttpUtility.UrlEncode(Properties.Settings.Default.apiKey));
                var request = new RestRequest(Method.PUT);
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
                    Message obj = JsonConvert.DeserializeObject<Message>(response.Content.ToString());
                    MessageBox.Show(obj.message);
                    main.Visible = false;
                    this.Refresh();
                }
            }
        }
        class Message
        {
            public string message { get; set; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(mission)
            {
            Load:
                var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Mission/" + id + "/ClearMission?apiKey=" + HttpUtility.UrlEncode(Properties.Settings.Default.apiKey));
                var request = new RestRequest(Method.PUT);
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
                    MessageBox.Show("Xóa nhiệm vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main.Visible = false;
                    this.Refresh();
                }
            }
            else
            {
            Load:
                var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/MissionOrder/" + id + "/Delete?apiKey=" + HttpUtility.UrlEncode(Properties.Settings.Default.apiKey));
                var request = new RestRequest(Method.PUT);
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
                    MessageBox.Show("Xóa nhận nhiệm vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main.Visible = false;
                    this.Refresh();
                }
            }
           
        }
    }
}
