using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Admins.Models
{
    internal class AdminListRequest : IAdminListRequest
    {
        public IEnumerable<long> UserId { get; set; }
    }
}
