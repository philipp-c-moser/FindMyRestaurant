using System.Web.Mvc;
using FindMyRestaurant.Framework.Controllers;

namespace FindMyRestaurant.Controllers
{
    public class HomeController : MvcControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
        
    }
}