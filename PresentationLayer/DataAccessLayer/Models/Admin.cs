using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Admin
    {
        public int admin_id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public string ToString()
        {
            return (admin_id + " " + name + " " + surname + " " + username + " " + password);
        }
    }
}
