using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using update_site.Areas.Admin.Adaptors;
using update_site.Entities;
using update_site.repo;

namespace update_site.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/Admin/

        private SiteRepository _repo= new SiteRepository();

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Updates()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Updates(Update update, List<string> SelectedOSs)
        {
            var list = _repo.GetOsList();
            var osList = new List<OS>();
            foreach (var os in list)
            {
                if(SelectedOSs.Contains(os.Name))
                    osList.Add(os);
            }
            //update.OperatingSystems = osList;
            foreach (var os in osList)
            {
                if(os.Updates == null)
                    os.Updates = new List<Update>();
                os.Updates.Add(update);
            }
               
            _repo.SaveChanges();
            return View();
        }


        /// <summary>
        /// Reads in the xml file and adds each update to the database
        /// BE SURE TO CHECK WHICH SYSTEM IT'S ADDING THEM TO! Default is windows 7
        /// </summary>
        /// <param name="file">The xml file containg the updates to add</param>
        /// <returns>The home page again</returns>
        [HttpPost]
        public ActionResult UpdatesXml(HttpPostedFileBase file)
        {
            if(file != null && file.ContentLength > 0)
            {
                var serializer = new XmlSerializer(typeof(List<Update>));
                var reader = new StreamReader(file.InputStream);
                var updates = (List<Update>)serializer.Deserialize(reader);
                var sr = new SiteRepository();
                foreach (var update in updates)
                {
                    update.Is32Bit = true;
                    sr.AddUpdate(update);
                }
                return View("~/Views/Home/Index.cshtml");
            }
            return View("Updates");
        }


        public ActionResult Drivers()
        {
            return View();
        }

        public ActionResult Computers()
        {
            return View();
        }

        public ActionResult Companies()
        {
            return View();
        }
    }
}
