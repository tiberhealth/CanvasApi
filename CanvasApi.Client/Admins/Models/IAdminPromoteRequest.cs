using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminPromoteRequest

    {
        /// <summary>
        /// The id of the user to promote.
        /// </summary>
        [Multipart("user_id")] int UserId { get; set; }

        /// <summary>
        /// 	
        /// DEPRECATED
        /// The user's admin relationship with the account will be
        ///
        /// created with the given role.Defaults to 'AccountAdmin'.
        /// </summary>
        [Multipart("role"), Obsolete("DEPRECATED - see https://canvas.instructure.com/doc/api/admins.html")]
        string Role { get; set; }

        /// <summary>
        /// The user's admin relationship with the account will be created with the given role.
        /// 
        /// Defaults to the built-in role for 'AccountAdmin'.
        /// </summary>
        [Multipart("role_id")] int? RoleId { get; set; }

        /// <summary>
        /// Send a notification email to the new admin if true. Default is true.
        /// </summary>
        [Multipart("send_confirmation")] bool? SendConfirmation { get; set; }
    }
}