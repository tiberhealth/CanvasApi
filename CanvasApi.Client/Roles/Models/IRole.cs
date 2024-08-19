using System;
using CanvasApi.Client.Roles.Enums;

namespace CanvasApi.Client.Roles.Models
{
    public interface IRole
    {
        long Id { get; }
        /// <summary>
        /// The role type that is being used as a base for this role. For account-level
        /// roles, this is 'AccountMembership'. For course-level roles, it is an
        /// enrollment type.
        /// </summary>
        RoleBaseTypes BaseRoleType { get; }
        /// <summary>
        /// The label of the role.
        /// </summary>
        string Label { get; }
        /// <summary>
        /// JSON representation of the account the role is in.
        /// </summary>
        IRoleAccount Account { get; }
        /// <summary>
        /// The state of the role: 'active', 'inactive', or 'built_in'
        /// </summary>
        RoleWorkflowState WorkflowState { get; }
        /// <summary>
        /// A dictionary of permissions keyed by name (see permissions input parameter in
        /// the 'Create a role' API).
        /// </summary>
        object Permissions { get; }
        // TODO: Create Permission Serialization process - can be next release/version
        
        DateTime? CreatedAt { get; set; }
        DateTime? LastUpdatedAt { get; set; }


    }
}