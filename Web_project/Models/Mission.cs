using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_project.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Customer { get; set; }
        public string Location { get; set; }
        public string Condition { get; set; }
        public string Date { get; set; }
    }
}
