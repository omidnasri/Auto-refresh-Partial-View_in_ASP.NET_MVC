using System.Web.Mvc;

namespace Auto_refresh_Partial_View_in_ASP.NETMVC.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var db = new Models.Databse();
            return View(db.RandomUser());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public PartialViewResult GetRandomUser()
        {
            var db = new Models.Databse();
            return PartialView("/Views/Home/_User.cshtml", db.RandomUser());
        }
    }
}