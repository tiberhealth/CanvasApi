using CanvasApi.Client.Roles.Enums;
using System.Collections.Generic;

namespace CanvasApi.Client.Roles.Models
{
    public interface IListRolesOptions
    {
        /// <summary>
        /// The id of the account to retrieve roles for.
        /// </summary>
        long AccountId { get; set; }
        /// <summary>
        /// If this argument is true, all roles inherited from parent accounts will be included.
        /// </summary>
        bool? ShowInherited { get; set; }
        /// <summary>
        /// Filter by role state. If this argument is omitted, only 'active' roles are returned.
        /// 
        /// Allowed values: <see cref="RoleWorkflowState">
        /// </summary>
        IEnumerable<RoleWorkflowState> State { get; set; }
    }
}