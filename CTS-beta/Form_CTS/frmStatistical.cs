using System;
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

        private void frmStatistical_Load_1(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
            button1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 5, 5));
            button2.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 5, 5)); 
            radTextBox1.Region = Region.FromHrgn(RoundBorder.CreateRoundRectRgn(0, 0, radTextBox1.Width, radTextBox1.Height, 5, 5));

            Thread thread = new Thread(new ThreadStart(LoadData));
            thread.Start();
        }

        void LoadData()
        {
            var client = new RestClient("https://api.hotrogame.online/Account/RankEmployee?apiKey=hello");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            RootObject obj = JsonConvert.DeserializeObject<RootObject>(response.Content.ToString());
            List<Rank> ranks = obj.results;
            int i = 1;
            foreach (var item in ranks)
            {
                {
                    if(!data.InvokeRequired)
                        data.Rows.Add(i++, item.id_employee, item.name_employee, item.point);
                    else
                        data.Invoke(new Action(() => data.Rows.Add(i++, item.id_employee, item.name_employee, item.point)));               }
                }

            }
        }

        class RootObject
        {
            public List<Rank> results { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }


    }
