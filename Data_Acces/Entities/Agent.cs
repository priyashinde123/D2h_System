using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces.Entities
{
    public class Agent
    {
        public int id { get; set; }
        public string name { get; set; }
        public int authority_id { get; set; }
        public int gid { get; set; }
        public string agent_username { get; set; }
        public string agent_password { get; set; }
    }
}
