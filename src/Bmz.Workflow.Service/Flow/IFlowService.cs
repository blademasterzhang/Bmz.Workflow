using Bmz.Workflow.Service.Flow.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmz.Workflow.Service.Flow
{
    public interface IFlowService
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
