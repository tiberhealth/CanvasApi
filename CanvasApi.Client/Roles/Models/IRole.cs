using CanvasApi.Client.Roles.Enums;
using System.Collections.Generic;

namespace CanvasApi.Client.Roles.Models
{
    public interface IRole
    {
        IEnumerable<RoleBaseTypes> BaseRoleType { get; }
        long Label { get; }
    }
}