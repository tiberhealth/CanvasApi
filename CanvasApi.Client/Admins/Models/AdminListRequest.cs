using System.Collections.Generic;

namespace CanvasApi.Client.Admins.Models
{
    internal class AdminListRequest : IAdminListRequest
    {
        public IEnumerable<long> UserId { get; set; }
    }
}
