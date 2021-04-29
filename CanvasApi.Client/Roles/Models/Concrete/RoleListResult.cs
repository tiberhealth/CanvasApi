using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanvasApi.Client.Roles.Models.Concrete
{
    class RoleListResult
    {
        public IEnumerable<Role> Roles { get; set; }
        public static IEnumerable<Role> ToArray(RoleListResult apiResult) => apiResult.Roles.ToArray();
    }
}
