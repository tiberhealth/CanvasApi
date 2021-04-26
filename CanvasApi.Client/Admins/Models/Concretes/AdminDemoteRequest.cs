using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Admins.Models
{
    class AdminDemoteRequest : IAdminDemoteRequest
    {
        public string Role { get; set; }
        public int? RoleId { get; set; }
    }
}
