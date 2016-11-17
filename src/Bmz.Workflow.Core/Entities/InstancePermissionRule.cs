using Bmz.Workflow.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmz.Workflow.Core.Entities
{
    public class InstancePermissionRule
    {
        /// <summary>
        /// instance permission rule type
        /// </summary>
        public InstancePermissRuleTypeEnum Type { get; set; }

        /// <summary>
        /// rule object represent type
        /// </summary>
        [MaxLength(200)]
        public string RuleObj { get; set; }

        /// <summary>
        /// node permission
        /// </summary>
        public PermissionEnum Permission { get; set; }
    }
}
