using CanvasApi.Client.Roles.Enums;
using System;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models.Concrete
{
    internal class Role : IRole
    {
        [Multipart("label")] public string Label { get; set; }
        [Multipart("base_role_type")] public IEnumerable<RoleBaseTypes> BaseRoleType { get; set; }
        [Multipart("account")] public Account Account { get; set; }
        IAccount IRole.Account => this.Account;
        [Multipart("workflow_state")] public IEnumerable<RoleWorkflowState> WorkflowState { get; set; }
        [Multipart("permissions")] public object Permissions { get => null; set => new NotImplementedException("Permissions API not completed as of yet."); }
        // TODO: Create Permission Serialization process - can be next release/version
    }
}
