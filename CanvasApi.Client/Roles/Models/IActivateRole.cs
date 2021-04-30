using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IActivateRole
    {
        /// <summary>
        /// The unique identifier for the role
        /// </summary>
        [Multipart("role_id")] int RoleId { get; set; }
    }
}