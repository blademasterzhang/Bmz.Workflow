using Bmz.Framework.Modules;
using Bmz.Workflow.Core.Entities;
using Bmz.Workflow.Service.Flow;
using Bmz.Workflow.Service.Flow.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmz.Workflow.Service
{
    public class BmzWorkflowServiceModule : BmzModule
    {
        public override void PreInitialize()
        {
            IocManager.Register<IFlowService, FlowService>();
            base.PreInitialize();
        }

        public override void Initialize()
        {
            AutoMapper.Mapper.CreateMap<InstanceNodeDto, InstanceNodeHistory>();
            AutoMapper.Mapper.CreateMap<InstanceNodeHistory, InstanceNodeDto>();
            base.Initialize();
        }
    }
}
