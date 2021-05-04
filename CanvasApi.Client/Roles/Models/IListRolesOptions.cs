using CanvasApi.Client.Roles.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IListRolesOptions
    {
        /// <summary>
        /// The id of the account to retrieve roles for.
        /// </summary>
        [Multipart("account_id")] long AccountId { get; set; }
        /// <summary>
        /// If this argument is true, all roles inherited from parent accounts will be included.
        /// </summary>
        [Multipart("show_inherited")] bool? ShowInherited { get; set; }
        /// <summary>
        /// Filter by role state. If this argument is omitted, only 'active' roles are returned.
        /// 
        /// Allowed values: <see cref="RoleWorkflowState">
        /// </summary>
        [Multipart("state")] IEnumerable<RoleWorkflowState> State { get; set; }
    }
}