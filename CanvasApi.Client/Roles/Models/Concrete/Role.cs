using CanvasApi.Client.Roles.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Roles.Models.Concrete
{
    internal class Role : IRole
    {
        [JsonProperty("label")] public long Label { get; set; }
        [JsonProperty("base_role_type")] public IEnumerable<RoleBaseTypes> BaseRoleType { get; set; }
        IEnumerable<RoleBaseTypes> IRole.BaseRoleType => this.BaseRoleType;
    }
}
