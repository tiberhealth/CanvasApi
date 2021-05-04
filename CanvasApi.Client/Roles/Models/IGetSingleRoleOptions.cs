using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IGetSingleRoleOptions
    {
        /// <summary>
        /// The id of the account containing the role
        /// </summary>
        long AccountId { get; set; }
        /// <summary>
        /// The name for the role
        /// </summary>
        string Role { get; set; }
        /// <summary>
        /// The unique identifier for the role
        /// </summary>
        int RoleId { get; set; }
    }
}