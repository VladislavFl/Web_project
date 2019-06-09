using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_project.Models
{
    public class User
    {
        //public тип название {get; set;}
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Task { get; set; }
    }
}
