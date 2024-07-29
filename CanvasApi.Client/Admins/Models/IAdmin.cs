using CanvasApi.Client.Admins.Enums;
using CanvasApi.Client.Users.Models;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdmin
    {
        /// <summary>
        /// The unique identifier for the account role/user assignment.
        /// </summary>
        long Id { get; }

        /// <summary>
        /// The account role assigned. This can be 'AccountAdmin' or a user-defined role
        /// created by the Roles API.
        /// </summary>
        string Role { get; }

        /// <summary>
        /// The user the role is assigned to. See the Users API for details.
        /// </summary>
        IUser User { get; }

        /// <summary>
        /// The status of the account role/user assignment.
        /// </summary>
        AdminListWorkflowState WorkflowState { get; }
    }
}