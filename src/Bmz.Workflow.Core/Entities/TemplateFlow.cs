using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmz.Workflow.Core.Entities
{
    public class TemplateFlow
    {
        [MaxLength(50)]
        public string ApplicationCode { get; set; }

        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public virtual ICollection<TemplateNode> TemplateNodes { get; set; }
    }
}
