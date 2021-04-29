using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IActivateRole
    {
        [Multipart("role_id")] int RoleId { get; set; }
    }
}