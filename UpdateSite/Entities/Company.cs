using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace update_site.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Computer> Computers { get; set; } 
    }
}