using Bmz.Framework.Auditing;
using Bmz.Framework.Domain.Uow;
using Bmz.Framework.WebApi.Authorization;
using Bmz.Framework.WebApi.Controllers;
using Bmz.Workflow.Service.Flow;
using Bmz.Workflow.Service.Flow.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bmz.Workflow.WebApi.Controllers
{
    public class FlowController : BmzApiController
    {
        IFlowService _flowService;

        public FlowController(IFlowService flowService)
        {
            this._flowService = flowService;
        }

        [Route("api/flow/ping")]
        [HttpGet]
        public string Ping()
        {
            return "pang";
        }

        [BmzApiAuthorize("")]
        [Audited]
        [DisableAuditing]
        [AllowAnonymous]
        [UnitOfWork]
        public IEnumerable<InstanceNodeDto> GetNode()
        {
            var list = this._flowService.GetInstanceFlowNodes(1);
            return list;
        }
    }
}
