using Bmz.Framework.Modules;
using Bmz.Framework.WebApi.Controllers.Dynamic.Builders;
using Bmz.Workflow.Service.Flow;
using Bmz.Workflow.Service.User;
using Castle.MicroKernel.Registration;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Bmz.Workflow.WebApi.Startup
{
    public class BmzWorkflowWebApiModule:BmzModule
    {
        public override void Initialize()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            IocManager.IocContainer.Register(Classes.FromThisAssembly().BasedOn<ApiController>().LifestyleTransient());
            CreateWebApiProxiesForServices();
        }

        private static void CreateWebApiProxiesForServices()
        {
            //TODO: must be able to exclude/include all methods option
            DynamicApiControllerBuilder
                .For<IFlowService>("workflow/flow")
                .Build();

            DynamicApiControllerBuilder
                .For<IUserService>("workflow/user")
                .Build();
        }
    }
}