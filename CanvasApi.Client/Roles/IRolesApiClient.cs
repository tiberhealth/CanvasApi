using CanvasApi.Client.Roles.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CanvasApi.Client.Roles
{
    public interface IRolesApiClient
    {
        /// <summary>
        /// Re-activates an inactive role (allowing it to be assigned to new users)
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        Task<IRole> ActivateRole(long accountId, long id, Action<IActivateRole> options);
        Task<JObject> CreateRole();
        /// <summary>
        /// Deactivates a custom role. This hides it in the user interface and prevents it from being assigned to new users. Existing users assigned to the role will continue to function with the same permissions they had previously. Built-in roles cannot be deactivated.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        Task<IRole> DeactivateRole(long accountId, long id, Action<IDeactivateRole> options);
        /// <summary>
        /// Retrieve information about a single role
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="id"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        Task<IRole> GetSingleRole(long accountId, long id, Action<IGetSingleRoleOptions> options);
        /// <summary>
        /// A paginated list of the roles available to an account.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        Task<IEnumerable<IRole>> ListRoles(long accountId, Action<IListRolesOptions> options);
        Task<JObject> UpdateRole();
    }
}