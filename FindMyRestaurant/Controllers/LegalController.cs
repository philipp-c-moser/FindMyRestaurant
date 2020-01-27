using System.Web.Mvc;

using FindMyRestaurant.Framework.Controllers;

namespace FindMyRestaurant.Controllers
{
    public class LegalController : MvcControllerBase
    {
        // GET: Legal
        public ActionResult Imprint()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}