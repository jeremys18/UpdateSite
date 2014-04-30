using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using update_site.Entities;

namespace update_site.repo
{
    public class SiteRepository
    {
        private Context _context;

        public SiteRepository()
        {
           _context = new Context();
        }

        public List<OS> GetOsList()
        {
            return _context.OperatingSystems.ToList();
        }

        public OS GetOs(string osName)
        {
            _context.ChangeTracker.DetectChanges();
            var os = from osy in _context.OperatingSystems
                            .Include("Updates")
                            where osy.Name == osName
                        select osy;
            return os.FirstOrDefault();
        }

        public List<Company> GetCompanyList()
        {
            var items = from comp in _context.Companies
                            .Include("Computers")
                        select comp;

            return items.ToList();
        }

        public Company GetCompany(string companyName)
        {
            return _context.Companies.First(x => x.Name == companyName);
        }

        public List<Update> GetUpdateList()
        {
            return _context.Updates.ToList();
        }

        public void AddOs(OS os)
        {
            _context.OperatingSystems.Add(os);
            SaveChanges();
        }

        public void AddUpdate(Update update)
        {
            var updates = GetOs("Windows 7").Updates ?? new List<Update>();
            if (updates.FirstOrDefault(x => x.KBNumber == update.KBNumber) == null)
                updates.Add(update);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void CreateOrRecreateDB()
        {
            _context.Database.Connection.Close();
            if(_context.Database.Exists())
                _context.Database.Delete();
            _context.Database.Create();_context.Database.Initialize(true);
        }
    }
}