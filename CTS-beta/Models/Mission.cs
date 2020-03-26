using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_beta.Models
{
    class Mission
    {
        public int id_mission { get; set; }
        public string name_mission { get; set; }
        public DateTime Stardate { get; set; }
        public int point { get; set; }
        public int exprie { get; set; }
        public string describe { get; set; }
        public int status { get; set; }
        public int Count { get; set; }
        public int id_type { get; set; }
        public int id_employee { get; set; }
    }
}
