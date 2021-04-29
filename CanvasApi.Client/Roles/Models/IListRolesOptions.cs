using CanvasApi.Client.Roles.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IListRolesOptions
    {
        [Multipart("account_id")] long AccountId { get; set; }
        [Multipart("show_inherited")] bool? ShowInherited { get; set; }
        [Multipart("state")] IEnumerable<RoleWorkflowState> State { get; set; }
    }
}