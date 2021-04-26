using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminDemoteRequest
    {
        /// <summary>
        /// DEPRECATED
        /// Account role to remove from the user.Defaults to
        ///
        /// 'AccountAdmin'. Any other account role must be specified explicitly.
        /// </summary>
        [Multipart("role"), Obsolete("DEPRECATED - see https://canvas.instructure.com/doc/api/admins.html")]
        public string Role { get; set; }

        /// <summary>
        /// The user's admin relationship with the account will be created with the given role. 
        /// 
        /// Defaults to the built-in role for 'AccountAdmin'.
        /// </summary>
        [Multipart("role_id")] int? RoleId { get; set; }
    }
}