using System.Web.Mvc;

using FindMyRestaurant.Framework.Controllers;

namespace FindMyRestaurant.Controllers
{
    public class RestaurantController : MvcControllerBase
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            return View();
        }
    }
}