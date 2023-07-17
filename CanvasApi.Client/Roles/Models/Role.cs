using CanvasApi.Client.Roles.Enums;
using Newtonsoft.Json;
using System;

namespace CanvasApi.Client.Roles.Models
{
    internal class Role : IRole
    {
        public string Label { get; set; }
        public RoleBaseTypes BaseRoleType { get; set; }
        public RoleAccount Account { get; set; }
        IRoleAccount IRole.Account => Account;
        public RoleWorkflowState WorkflowState { get; set; }
        public object Permissions { get => null; set => new NotImplementedException("Permissions API not completed as of yet."); }
        // TODO: Create Permission Serialization process - can be next release/version
    }
}
