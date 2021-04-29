using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IGetSingleRoleOptions
    {
        [Multipart("account_id")] long AccountId { get; set; }
        [Multipart("role")] string Role { get; set; }
        [Multipart("role_id")] int RoleId { get; set; }
    }
}