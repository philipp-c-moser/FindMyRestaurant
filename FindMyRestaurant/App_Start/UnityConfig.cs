using System.Web.Http;
using Unity;
using Unity.WebApi;

using FindMyRestaurant.Core;
using FindMyRestaurant.Infrastructure;

namespace FindMyRestaurant
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}