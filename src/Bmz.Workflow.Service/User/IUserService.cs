using Bmz.Workflow.Service.Flow.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmz.Workflow.Service.User
{
    public interface IUserService
    {
        /// <summary>
        /// get user's todo nodes
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="roleCode"></param>
        /// <returns></returns>
        IEnumerable<InstanceNodeDto> GetNodeTodoOfUser(string userCode,List<string> roleCode);
        
        /// <summary>
        /// whether user has permission of the instance node
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="roleCode"></param>
        /// <param name="nodeCode"></param>
        /// <returns></returns>
        bool UserHasPermissionToInstanceNode(string userCode,List<string> roleCode,string nodeCode);

        /// <summary>
        /// todo current node and create next node by permission rule
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="nodeCode"></param>
        /// <returns></returns>
        bool TodoAndCreateNextNode(string userCode,string nodeCode);
    }
}