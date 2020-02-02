using System.Web.Mvc;

using FindMyRestaurant.Framework.Controllers;

namespace FindMyRestaurant.Controllers
{
    public class FindController : MvcControllerBase
    {
        // GET: Find
        public ActionResult Index()
        {
            return View();
        }
    }
}