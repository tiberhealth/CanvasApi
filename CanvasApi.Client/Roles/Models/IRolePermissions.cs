using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IRolePermissions
    {
        /// <summary>
        /// Whether the role has the permission
        /// </summary>
        bool? Enabled { get; }
        /// <summary>
        /// Whether the permission is locked by this role
        /// </summary>
        bool? Locked { get; }
        /// <summary>
        /// Whether the permission applies to the account this role is in. Only present
        /// if enabled is true
        /// </summary>
        bool? AppliesToSelf { get; }
        /// <summary>
        /// Whether the permission cascades down to sub accounts of the account this role
        /// is in. Only present if enabled is true
        /// </summary>
        bool? AppliesToDescendants { get; }
        /// <summary>
        /// Whether the permission can be modified in this role (i.e. whether the
        /// permission is locked by an upstream role).
        /// </summary>
        bool? ReadOnly { get; }
        /// <summary>
        /// Whether the value of enabled is specified explicitly by this role, or
        /// inherited from an upstream role.
        /// </summary>
        bool? Explicit { get; }
        /// <summary>
        /// The value that would have been inherited from upstream if the role had not
        /// explicitly set a value. Only present if explicit is true.
        /// </summary>
        bool? PriorDefault { get; }
    }
}
