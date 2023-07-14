using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    internal class RolePermissions : IRolePermissions
    {
        public bool? Enabled { get; set; }
        public bool? Locked { get; set; }
        public bool? AppliesToSelf { get; set; }
        public bool? AppliesToDescendants { get; set; }
        public bool? ReadOnly { get; set; }
        public bool? Explicit { get; set; }
        public bool? PriorDefault { get; set; }
    }
}
