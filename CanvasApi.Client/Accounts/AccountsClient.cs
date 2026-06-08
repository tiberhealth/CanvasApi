namespace CanvasApi.Client.Accounts;

internal class AccountsClient: ApiClientBase, IAccountsApi
{        
    public AccountsClient(CanvasApiClient parent): base(parent) { }

    public void CreateSubAccount(long accountId)
    {
        throw new NotImplementedException();
    }

    public void DeleteSubAccount(long accountId, long subAccountId)
    {
        throw new NotImplementedException();
    }

    public void DeleteUserFromRootAccount(long accounId, long userId)
    {
        throw new NotImplementedException();
    }

    public async Task<IAccount> GetAccount(long accountId) =>
        await this.ApiClient.ApiOperation<Account>(HttpMethod.Get, $"/api/v1/accounts/{accountId}");
               

    public void GetHelpLinks(long accountId)
    {
        throw new NotImplementedException();
    }

    public void GetPermission(long accountId, params string[] permissions)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Account>> GetSubAccounts(long accountId, bool recursive = false)
    {
        var url = $"/api/v1/accounts/{accountId}/sub_accounts?recursive={recursive.ToString()}";
        var results = await this.ApiClient.PagableApiOperation<Account>(HttpMethod.Get, url);

        return results;
    }

    public Task<IEnumerable<Account>> GetSubAccounts(Account parentAccount, bool recursive = false) =>
        parentAccount != null ? this.GetSubAccounts(parentAccount.Id, recursive) : throw new ArgumentNullException(nameof(parentAccount));

    public void GetTermsOfService(long accountId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Account>> List(params Accountinclude[] include)
    {
        var url = "/api/v1/accounts";
        if ((include?.Length ?? 0) > 0) url += $"?include[]={string.Join(',', include)}";

        var results = await this.ApiClient.PagableApiOperation<Account>(HttpMethod.Get, url);

        return results;
    }
            

    public void ListActiveCourses(long accountId)
    {
        throw new NotImplementedException();
    }

    public void ListCourseAdminAccounts()
    {
        throw new NotImplementedException();
    }

    public void UpdateAccount(long accountId)
    {
        throw new NotImplementedException();
    }
}