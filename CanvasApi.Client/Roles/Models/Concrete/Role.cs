using CanvasApi.Client.Roles.Enums;
using System.Collections.Generic;

namespace CanvasApi.Client.Roles.Models.Concrete
{
    internal class Role : IRole
    {
        public long Label { get; set; }
        public IEnumerable<RoleBaseTypes> BaseRoleType { get; set; }
        IEnumerable<RoleBaseTypes> IRole.BaseRoleType => this.BaseRoleType;
    }
}
