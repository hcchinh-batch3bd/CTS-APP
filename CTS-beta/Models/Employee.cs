using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_beta.Models
{
    public class Employee
    {
        public int id_employee { get; set; }
        public string name_employee { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public DateTime date { get; set; }
        public int point { get; set; }
        public string level { get; set; }
        public string status { get; set; }
    }
}
