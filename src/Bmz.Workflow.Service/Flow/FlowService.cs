using Bmz.Framework.Domain.Repositories;
using Bmz.Workflow.Core.Entities;
using Bmz.Workflow.Service.Flow.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmz.Workflow.Service.Flow
{
    public class FlowService : IFlowService
    {
        IRepository<InstanceNodeHistory> _instanceNodeHistoryRepository;

        //public FlowService(IRepository<InstanceNodeHistory> instanceNodeHistoryRepository)
        //{
        //    this._instanceNodeHistoryRepository = instanceNodeHistoryRepository;
        //}

        public IEnumerable<InstanceNodeDto> GetInstanceFlowNodes(long InstanceFlowId)
        {
            var list = new List<InstanceNodeDto>();
            list.Add(new InstanceNodeDto()
            {
                Id = 1,
                Name = "开始节点"
            });
            list.Add(new InstanceNodeDto()
            {
                Id = 2,
                Name = "项目设计"
            });
            return list;
        }

        public IEnumerable<TemplateNodeDto> GetTemplateFlowNodes(string TemplateFlowCode)
        {
            throw new NotImplementedException();
        }
    }
}
