using CanvasApi.Client.Admins.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CanvasApi.Client.Admins
{
    public interface IAdminApiClient
    {
        /// <summary>
        /// A paginated list of the admins in the account
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        Task<IEnumerable<IAdmin>> List(long accountId, Action<IAdminListRequest> body);

        /// <summary>
        /// Flag an existing user as an admin within the account.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="admin"></param>
        /// <returns></returns>
        Task<IAdmin> Promote(long accountId, Action<IAdminPromoteRequest> admin);

        /// <summary>
        /// Remove the rights associated with an account admin role from a user.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        Task<IAdmin> Demote(long accountId, long userId, Action<IAdminDemoteRequest> options = null);
    }
}
