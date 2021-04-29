using CanvasApi.Client.Roles.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IRole
    {
        [Multipart("base_role_type")] IEnumerable<RoleBaseTypes> BaseRoleType { get; }
        [Multipart("label")] string Label { get; }
        [Multipart("account")] IAccount Account { get; }
        [Multipart("workflow_state")] public IEnumerable<RoleWorkflowState> WorkflowState { get; }
        [Multipart("permissions")] public object Permissions { get; }
        // TODO: Create Permission Serialization process - can be next release/version
    }
}