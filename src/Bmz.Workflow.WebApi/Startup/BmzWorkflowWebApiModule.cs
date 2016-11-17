using Bmz.Framework.Modules;
using Bmz.Framework.WebApi.Controllers.Dynamic.Builders;
using Bmz.Workflow.Service.Flow;
using Bmz.Workflow.Service.User;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Bmz.Workflow.WebApi.Startup
{
    public class BmzWorkflowWebApiModule:BmzModule
    {
        public override void Initialize()
        {
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