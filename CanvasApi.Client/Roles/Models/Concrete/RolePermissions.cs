using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models.Concrete
{
    internal class RolePermissions : IRolePermissions
    {
        [Multipart("enabled")] public bool? Enabled { get; set; }
        [Multipart("locked")] public bool? Locked { get; set; }
        [Multipart("applies_to_self")] public bool? AppliesToSelf { get; set; }
        [Multipart("applies_to_descendants")] public bool? AppliesToDescendants { get; set; }
        [Multipart("read_only")] public bool? ReadOnly { get; set; }
        [Multipart("explicit")] public bool? Explicit { get; set; }
        [Multipart("prior_default")] public bool? PriorDefault { get; set; }
    }
}
