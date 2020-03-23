using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_beta.Models
{
    class TypeMission
    {
        public int id_type { get; set; }
        public string name_type_mission { get; set; }
        public int id_employee { get; set; }
        public bool status { get; set; }
        public DateTime date { get; set; }
    }
}
