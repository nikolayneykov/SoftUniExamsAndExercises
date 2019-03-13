using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ProjectRider.Models;

namespace ProjectRider
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
	        var initializer =
		        new CreateDatabaseIfNotExists<ProjectRiderDbContext>();


	        Database.SetInitializer(initializer);

			AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
