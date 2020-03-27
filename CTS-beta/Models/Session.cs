using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_beta.Models
{
    class Session
    {
        public int id_employee { get; set; }
        public string name_employee { get; set; }
        public int point { get; set; }
        public bool level_employee { get; set; }
        public string apiKey { get; set; }
    }
}
