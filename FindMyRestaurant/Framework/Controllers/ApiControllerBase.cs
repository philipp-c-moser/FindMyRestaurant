using System.Web.Http;

namespace FindMyRestaurant.Framework.Controllers
{
    public class ApiControllerBase : ApiController
    {
        protected readonly int _amountOfItemsForQuickTables;

        public ApiControllerBase()
        {
            _amountOfItemsForQuickTables = int.Parse(System.Configuration.ConfigurationManager.AppSettings["Config:AmountOfItemsForQuickTables"]);
        }

    }
}