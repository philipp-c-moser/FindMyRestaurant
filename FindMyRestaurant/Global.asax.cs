using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using FindMyRestaurant.Infrastructure.Data;
using FindMyRestaurant.Infrastructure.Data.Migrations;
using FindMyRestaurant.Routes;
using FindMyRestaurant.Infrastructure.Mapping;

namespace FindMyRestaurant
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<MappingProfile>());

            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());
            var migrateDb = new AppDbContext();
            migrateDb.Database.Initialize(true);
        }
    }
}
