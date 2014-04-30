using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using update_site.Entities;

namespace update_site.Controllers
{
    public class DriversController : BaseController
    {
        //
        // GET: /Drivers/



        public ActionResult Index()
        {
            return View(Repo.GetCompanyList());
        }

        public ActionResult Computers(string companyName)
        {
            var company = Repo.GetCompanyList().First(x => x.Name == companyName);
            return View(company);
        }

    }
}
