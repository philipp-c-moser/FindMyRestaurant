using System.Web.Http;

namespace FindMyRestaurant.Framework.Controllers
{
    public class ApiControllerBase : ApiController
    {
        #region Fields
        protected readonly int _amountOfItemsForQuickTables;
        protected readonly int _secureMaxAmountOfItemsForRequests;
        #endregion

        public ApiControllerBase()
        {
            #region Configuration
            _amountOfItemsForQuickTables = int.Parse(System.Configuration.ConfigurationManager.AppSettings["Config:AmountOfItemsForQuickTables"]);
            _secureMaxAmountOfItemsForRequests = int.Parse(System.Configuration.ConfigurationManager.AppSettings["Config:SecureMaxAmountOfItemsForRequests"]);
            #endregion
        }

    }
}