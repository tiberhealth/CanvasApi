using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IRolePermissions
    {
        [Multipart("enabled")] bool? Enabled { get; }
        [Multipart("locked")] bool? Locked { get; }
        [Multipart("applies_to_self")] bool? AppliesToSelf { get; }
        [Multipart("applies_to_descendants")] bool? AppliesToDescendants { get; }
        [Multipart("read_only")] bool? ReadOnly { get; }
        [Multipart("explicit")] bool? Explicit { get; }
        [Multipart("prior_default")] bool? PriorDefault { get; }
    }
}
