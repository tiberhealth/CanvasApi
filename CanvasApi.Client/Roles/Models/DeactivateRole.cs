using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Roles.Models
{
    internal class DeactivateRole : IDeactivateRole
    {
        public int RoleId { get; set; }
        public string Role { get; set; }
    }
}
