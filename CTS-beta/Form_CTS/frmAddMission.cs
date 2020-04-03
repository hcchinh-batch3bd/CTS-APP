﻿using System;
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
using System.Text.RegularExpressions;

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



        private void Button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmAddMission_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControl.ReleaseCapture();
            MoveControl.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoadTypeMission()
        {
        Load:
            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Type_Mission/GetAll");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if (!response.IsSuccessful)
            {
                DialogResult dialog = MessageBox.Show("Máy chủ bị mất kết nối !!!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Retry)
                    goto Load;
                else
                {
                    Properties.Settings.Default.apiKey = "";
                    Properties.Settings.Default.id_employee = 0;
                    Properties.Settings.Default.Save();
                    Application.Exit();
                }
            }
            else
            {
                List<TypeMission> listTypes = JsonConvert.DeserializeObject<List<TypeMission>>(response.Content.ToString());
                DataTable dt = new DataTable();
                dt.Columns.Add("id_type", typeof(String));
                dt.Columns.Add("name_type_mission", typeof(String));
                foreach (var list in listTypes)
                {
                    if (list.status)
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
        }

        //Add a Mission
        private void AddMission()
        {
            string Namemission = Regex.Replace(txtNameMission.Text, @"\s+", " ");
            string Describe = Regex.Replace(txtDescribe.Text, @"\s+", " ");
            if (Namemission.Trim()!="" && !txtCount.Text.Equals("") && !txtPoint.Text.Equals("") && !txtExprie.Text.Equals("") && Describe.Trim()!="")
            {
                if (txtCount.Text.All(char.IsDigit) && txtExprie.Text.All(char.IsDigit) && txtPoint.Text.All(char.IsDigit))
                {
                    if (int.Parse(txtCount.Text) > 100)
                        MessageBox.Show("Số lượng nhiệm vụ phải từ 0-100.\n*Với 0: Không giới hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    else
                    {
                        if (int.Parse(txtExprie.Text) > 30)
                            MessageBox.Show("Số ngày hết hạn phải từ 0-30.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            if (int.Parse(txtPoint.Text) > 1000 || int.Parse(txtPoint.Text) == 0)
                            MessageBox.Show("Điểm của nhiệm vụ phải từ 1-1000.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            string nameMission = Namemission.Trim();
                            int idTypeMission = int.Parse(ddlTypeMission.SelectedItem.Value.ToString());
                            int count = int.Parse(txtCount.Text);
                            int point = int.Parse(txtPoint.Text);
                            string Stardate = DateTime.Today.ToShortDateString();
                            int exprie = int.Parse(txtExprie.Text);
                            string describe = Describe.Trim();
                            int status = 0;
                            int idEmployee = Properties.Settings.Default.id_employee;
                        Load:
                            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Mission/Create?apiKey=" + frmUser.Instance.ApiKey);
                            var request = new RestRequest(Method.POST);
                            request.AddHeader("content-type", "application/json");
                            request.AddParameter("undefined", "{\"name_mission\":\'" + nameMission + "',\"Stardate\":\'" + Stardate + "',\"point\":" + point + " ,\"exprie\":" + exprie + ",\"describe\":\'" + describe + "',\"status\":\'" + status + "',\"count\":" + count + ",\"id_type\":" + idTypeMission + ",\"id_employee\":" + idEmployee + "}", ParameterType.RequestBody);
                            IRestResponse response = client.Execute(request);
                            if (!response.IsSuccessful)
                            {
                                DialogResult dialog = MessageBox.Show("Máy chủ bị mất kết nối !!!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                if (dialog == DialogResult.Retry)
                                    goto Load;
                                else
                                {
                                    Properties.Settings.Default.apiKey = "";
                                    Properties.Settings.Default.id_employee = 0;
                                    Properties.Settings.Default.Save();
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Message obj = JsonConvert.DeserializeObject<Message>(response.Content.ToString());
                                MessageBox.Show(obj.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }

                }
                else
                    MessageBox.Show("Vui lòng nhập dữ liệu là số nguyên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Chưa nhập đủ thông tin");
        }

        private void FrmAddMission_Load(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(LoadTypeMission));
            thread.Start();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            AddMission();
        }
        public class Message
        {
            public string message { get; set; }
        }
    }
}

