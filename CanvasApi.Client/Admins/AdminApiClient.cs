using CanvasApi.Client._Base;
using CanvasApi.Client.Admins.Models;
using CanvasApi.Client.Extentions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CanvasApi.Client.Admins
{
    internal class AdminApiClient : ApiClientBase, IAdminApiClient
    {
        public AdminApiClient(CanvasApiClient parent) : base(parent) { }

        public async Task<IAdmin> Promote(long accountId, Action<IAdminPromoteRequest> admin) =>
            await ApiClient.ApiOperation<Admin, IAdminPromoteRequest>(
                HttpMethod.Post,
                $"/api/v1/accounts/{accountId}/admins",
                admin.GetOptions<IAdminPromoteRequest, AdminPromoteRequest>()
                );

        public async Task<IAdmin> Demote(long accountId, long userId, Action<IAdminDemoteRequest> options = null) =>
            await ApiClient.ApiOperation<Admin, IAdminDemoteRequest>(
                HttpMethod.Delete,
                $"/api/v1/accounts/{accountId}/admins/{userId}",
                options.GetOptions<IAdminDemoteRequest, AdminDemoteRequest>()
                );

        public async Task<IEnumerable<IAdmin>> List(long accountId, Action<IAdminListRequest> body) =>
            await ApiClient.PagableApiOperation<Admin, IAdminListRequest>(
                HttpMethod.Get,
                $"/api/v1/accounts/{accountId}/admins",
                body.GetOptions<IAdminListRequest, AdminListRequest>()
                );
    }
}
