using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace update_site.Entities
{
    [Serializable]
    public class Update2
    {
        public Update2()
        {
            
        }

        public string Title { get; set; }
        public int KB { get; set; }
        public string Description {  get;  set; }
    }
}