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
        public Mission(int id_mission, string name_mission, DateTime Stardate, int point, int exprie, string describe, int status, int Count, int id_type, int id_employee)
        {
            this.id_mission = id_mission;
            this.name_mission = name_mission;
            this.Stardate = Stardate;
            this.point = point;
            this.exprie = exprie;
            this.describe = describe;
            this.status = status;
            this.Count = Count;
            this.id_type = id_type;
            this.id_employee = id_employee;
        }
    }
}
