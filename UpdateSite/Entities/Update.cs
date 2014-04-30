using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace update_site.Entities
{
    public class Update
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripton { get; set; }
        //public List<OS> OperatingSystems { get; set; } 
        public int KBNumber { get; set; }
    }
}