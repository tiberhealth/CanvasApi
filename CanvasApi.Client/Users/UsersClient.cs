using System;
using System.Net.Http;
using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.Users.Models;

namespace CanvasApi.Client.Users
{
    internal class UsersClient: ApiClientBase, IUsersApi
    {
        internal UsersClient(CanvasApiClient parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns user profile data, including user id, name, and profile pic.
        /// 
        /// When requesting the profile for the user accessing the API, the user's calendar feed URL and LTI user id will be returned as well.
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns><see cref="IUserProfile"/>Profile for the requested user</returns>
        public async Task<IUserProfile> GetProfile(long userId) =>
            await this.ApiClient.ApiOperation<UserProfile>(HttpMethod.Get, $"/api/v1/users/{userId}/profile");

    }
}
