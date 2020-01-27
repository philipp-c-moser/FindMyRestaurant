using System.Web.Mvc;

using FindMyRestaurant.Framework.Controllers;

namespace FindMyRestaurant.Controllers
{
    public class VisitController : MvcControllerBase
    {
        // GET: Visit
        public ActionResult Index()
        {
            return View();
        }
    }
}