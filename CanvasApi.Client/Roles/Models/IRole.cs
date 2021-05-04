using CanvasApi.Client.Roles.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IRole
    {
        /// <summary>
        /// The role type that is being used as a base for this role. For account-level
        /// roles, this is 'AccountMembership'. For course-level roles, it is an
        /// enrollment type.
        /// </summary>
        IEnumerable<RoleBaseTypes> BaseRoleType { get; }
        /// <summary>
        /// The label of the role.
        /// </summary>
        string Label { get; }
        /// <summary>
        /// JSON representation of the account the role is in.
        /// </summary>
        IAccount Account { get; }
        /// <summary>
        /// The state of the role: 'active', 'inactive', or 'built_in'
        /// </summary>
        public IEnumerable<RoleWorkflowState> WorkflowState { get; }
        /// <summary>
        /// A dictionary of permissions keyed by name (see permissions input parameter in
        /// the 'Create a role' API).
        /// </summary>
        public object Permissions { get; }
        // TODO: Create Permission Serialization process - can be next release/version
    }
}