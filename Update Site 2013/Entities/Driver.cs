using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace update_site.Entities
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Verstion { get; set; }
        public string Category { get; set; }
        public string FileLocation { get; set; }
    }
}