using CanvasApi.Client.Roles.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Roles.Models.Concrete
{
    internal class ListRolesOptions : IListRolesOptions
    {
        public IEnumerable<RoleWorkflowState> State { get; set; }
        public bool? ShowInherited { get; set; }
        public long AccountId { get; set; }
    }
}
