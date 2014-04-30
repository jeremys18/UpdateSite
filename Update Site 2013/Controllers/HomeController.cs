using System.Web.Mvc;

namespace update_site.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Index/

        public ActionResult Index()
        {
            //var repo = new SiteRepository();
            //repo.CreateOrRecreateDB();
            //repo.AddOs(new OS { Name = "Windows 98SE", Updates = new List<Update>() });
            //repo.AddOs(new OS { Name = "Windows XP", Updates = new List<Update>() });
            //repo.AddOs(new OS { Name = "Windows Vista", Updates = new List<Update>() });
            //repo.AddOs(new OS { Name = "Windows 7", Updates = new List<Update>() });
            //repo.SaveChanges();
            return View();
        }
    }
}
