using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using update_site.Entities;

namespace update_site.repo
{
    public class Context : DbContext
    {
        public DbSet<OS> OperatingSystems { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Update> Updates { get; set; } 
    }
}