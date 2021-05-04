using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IGetSingleRoleOptions
    {
        /// <summary>
        /// The id of the account containing the role
        /// </summary>
        [Multipart("account_id")] long AccountId { get; set; }
        /// <summary>
        /// The name for the role
        /// </summary>
        [Multipart("role")] string Role { get; set; }
        /// <summary>
        /// The unique identifier for the role
        /// </summary>
        [Multipart("role_id")] int RoleId { get; set; }
    }
}