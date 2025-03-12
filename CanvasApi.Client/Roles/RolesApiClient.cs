namespace CanvasApi.Client.Roles;

public class RolesApiClient : ApiClientBase, IRolesApiClient
{
    public RolesApiClient(CanvasApiClient parent) : base(parent) { }

    public async Task<IEnumerable<IRole>> ListRoles(long accountId, Action<IListRolesOptions> options) =>
        await this.ApiClient.PagableApiOperation<Role, RoleListResult, IListRolesOptions>(
            HttpMethod.Get,
            $"/api/v1/accounts/{accountId}/roles",
            options.GetOptions<IListRolesOptions, ListRolesOptions>(),
            RoleListResult.ToArray);

    public async Task<IRole> GetSingleRole(long accountId, long id, Action<IGetSingleRoleOptions> options) =>
        await this.ApiClient.ApiOperation<Role, IGetSingleRoleOptions>(
            HttpMethod.Get,
            $"/api/v1/accounts/{accountId}/roles/{id}",
            options.GetOptions<IGetSingleRoleOptions, GetSingleRoleOptions>()
        );

    public Task<JObject> CreateRole() =>
        throw new NotImplementedException("Permissions API not completed as of yet.");
    // TODO: Update after Permission Serialization process - can be next release/version

    public Task<JObject> UpdateRole() =>
        throw new NotImplementedException("Permissions API not completed as of yet.");
    // TODO: Update after Permission Serialization process - can be next release/version

    public async Task<IRole> DeactivateRole(long accountId, long id, Action<IDeactivateRole> options) =>
        await this.ApiClient.ApiOperation<Role, IDeactivateRole>(
            HttpMethod.Delete,
            $"/api/v1/accounts/{accountId}/roles/{id}",
            options.GetOptions<IDeactivateRole, DeactivateRole>()
        );

    public async Task<IRole> ActivateRole(long accountId, long id, Action<IActivateRole> options) =>
        await this.ApiClient.ApiOperation<Role, IActivateRole>(
            HttpMethod.Post,
            $"/api/v1/accounts/{accountId}/roles/{id}/activate",
            options.GetOptions<IActivateRole, ActivateRole>()
        );
}