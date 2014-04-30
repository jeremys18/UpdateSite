using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using update_site.Entities;
using update_site.repo;

namespace update_site.Controllers
{
    public class WindowsUpdatesController : BaseController
    {
        //
        // GET: /WindowsUpdates/

        public ActionResult Index()
        {
            
            return View(Repo.GetOsList());
        }

        public ActionResult UpdatesList(string os)
        {
            ViewBag.Title = "Updates for " + os;
            var updates = Repo.GetOs(os).Updates;
            return View(updates ?? new List<Update>());
        }

    }
}
