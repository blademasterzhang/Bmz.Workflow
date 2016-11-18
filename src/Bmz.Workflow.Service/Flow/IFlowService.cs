using Bmz.Framework.Application.Services;
using Bmz.Workflow.Service.Flow.Dto;
using System.Collections.Generic;

namespace Bmz.Workflow.Service.Flow
{
    public interface IFlowService:IApplicationService
    {
        /// <summary>
        /// get instance node of a flow
        /// </summary>
        /// <param name="InstanceFlowId"></param>
        /// <returns></returns>
        IEnumerable<InstanceNodeDto> GetInstanceFlowNodes(long InstanceFlowId);
        
        /// <summary>
        /// get template node of a flow
        /// </summary>
        /// <param name="TemplateFlowCode"></param>
        /// <returns></returns>
        IEnumerable<TemplateNodeDto> GetTemplateFlowNodes(string TemplateFlowCode);
    }
}
