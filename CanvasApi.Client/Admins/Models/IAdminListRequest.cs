using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminListRequest
    {
        /// <summary>
        /// Scope the results to those with user IDs equal to any of the IDs specified here.
        /// </summary>
        IEnumerable<long> UserId { get; set; }
    }
}
