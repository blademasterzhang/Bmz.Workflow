using Bmz.Framework.Domain.Entities.Auditing;
using Bmz.Workflow.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bmz.Workflow.Core.Entities
{
    public class InstanceNodeBase : AuditedEntity
    {
        public InstanceNodeStatusEnum Status { get; set; }

        public virtual ICollection<InstancePermissionRule> InstancePermissionRules { get; set; }

        public int TemplateNodeId { get; set; }

        [ForeignKey("TemplateNodeId")]
        public TemplateNode TemplateNode { get; set; }
    }
}
