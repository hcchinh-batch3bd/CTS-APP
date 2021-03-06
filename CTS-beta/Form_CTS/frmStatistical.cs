﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using CTS_beta.Models;
using System.Threading;
using System.Configuration;
using System.Web;

namespace CTS_beta
{
    public partial class frmStatistical : UserControl
    {
        public frmStatistical()
        {
            InitializeComponent();
            this.data.MasterTemplate.EnableGrouping = false;
            this.data.MasterTemplate.AllowDragToGroup = false;
            this.data.MasterTemplate.AutoExpandGroups = false;

        }

        private void frmStatistical_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            btnExcel.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, btnExcel.Width, btnExcel.Height, 5, 5));
            LoadData();

        }

        void LoadData()
        {
            Load:
            var client = new RestClient(ConfigurationManager.AppSettings["server"] + "/Account/RankEmployee?apiKey="+ HttpUtility.UrlEncode(Properties.Settings.Default.apiKey));
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
                if (!data.InvokeRequired)
                    data.Rows.Clear();
                else
                    data.Invoke(new Action(() => data.Rows.Clear()));
                RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
                List<Rank> ranks = obj.results;
                int i = 1;
                foreach (var item in ranks)
                {
                    {
                        if (!data.InvokeRequired)
                            data.Rows.Add(i++, item.id_employee, item.name_employee, item.point);
                        else
                            data.Invoke(new Action(() => data.Rows.Add(i++, item.id_employee, item.name_employee, item.point)));
                    }
                }

            }

        }

        class RootObject
        {
            public List<Rank> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < data.Columns.Count + 1; i++)
                {
                    app.Cells[1, i] = data.Columns[i - 1].HeaderText;

                }
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int j = 0; j < data.Columns.Count; j++)
                    {
                        app.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                    }
                }
                app.Columns.AutoFit();
                app.Visible = true;
            }
        }

        private void PicSyn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(LoadData)) { IsBackground = true };
            thread.Start();
            while (thread.IsAlive)
            {
                Application.DoEvents();
                PicSyn.Visible = false;
            }
            PicSyn.Visible = true;
        }
    }
}
