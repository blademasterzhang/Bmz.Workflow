using Bmz.Workflow.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bmz.Workflow.Core.Entities
{
    public class TemplateNode
    {
        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Url { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public TemplateNodeInRuleEnum InRule { get; set; }

        public int PositionLeft { get; set; }

        public int PositionTop { get; set; }

        public int TemplateFlowId { get; set; }

        [ForeignKey("TemplateFlowId")]
        public TemplateFlow TemplateFlow { get; set; }

        public virtual ICollection<TemplateNode> ParentTemplateNodes { get; set; }

        public virtual ICollection<TemplateNode> ChildTemplateNodes { get; set; }

        public virtual ICollection<TemplatePermissionRule> TemplatePermissionRules { get; set; }
    }
}
