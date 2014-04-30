using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using update_site.Entities;

namespace update_site.Areas.Admin.Adaptors
{
    public class UpdateModel
    {
        public Update Update { get; set; }
        public List<String> SelectedOSs { get; set; } 
    }
}