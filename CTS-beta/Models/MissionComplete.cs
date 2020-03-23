using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_beta.Models
{
    class MissionComplete
    {
        public int id_mission { get; set; }
        public string name_mission { get; set; }
        public int point { get; set; }
        public int id_type { get; set; }
        public DateTime date { get; set; }
    }
}
