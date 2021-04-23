using CanvasApi.Client._Base;
using CanvasApi.Client.Admins.Models;
using CanvasApi.Client.Extentions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CanvasApi.Client.Admins
{
    public class AdminApiClient : ApiClientBase, IAdminApiClient
    {
        public AdminApiClient(CanvasApiClient parent) : base(parent) { }

        public async Task<IAdmin> Promote(long accountId, Action<IAdminPromote> admin) =>
            await ApiClient.ApiOperation<Admin, IAdminPromote>(
                HttpMethod.Post,
                $"/api/v1/accounts/{accountId}/admins",
                admin.GetOptions<IAdminPromote, AdminPromote>()
                );

        public async Task<IAdmin> Demote(long accountId, long userId, Action<IAdminDemote> options = null) =>
            await ApiClient.ApiOperation<Admin, IAdminDemote>(
                HttpMethod.Delete,
                $"/api/v1/accounts/{accountId}/admins/{userId}",
                options.GetOptions<IAdminDemote, AdminDemote>()
                );

        public async Task<IEnumerable<IAdmin>> List(long accountId, Action<IAdminList> body) =>
            await ApiClient.PagableApiOperation<Admin, IAdminList>(
                HttpMethod.Get,
                $"/api/v1/accounts/{accountId}/admins",
                body.GetOptions<IAdminList, AdminList>()
                );
    }
}
