using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace update_site.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public List<Driver> Drivers { get; set; }
    }
}