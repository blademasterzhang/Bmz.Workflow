using Bmz.Workflow.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmz.Workflow.Core.Entities
{
    public class InstanceFlow
    {
        public InstanceFlowStatusEnum Status { get; set; }

        public int TemplateFlowId { get; set; }

        [ForeignKey("TemplateFlowId")]
        public TemplateFlow TemplateFlow { get; set; }
    }
}
