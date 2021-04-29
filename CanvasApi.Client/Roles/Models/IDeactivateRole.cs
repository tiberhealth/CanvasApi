using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IDeactivateRole
    {
        [Multipart("role")] string Role { get; set; }
        [Multipart("role_id")] int RoleId { get; set; }
    }
}