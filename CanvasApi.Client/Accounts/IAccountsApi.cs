namespace CanvasApi.Client.Accounts;

/// <summary>
/// Accounts API as Definied at https://canvas.instructure.com/doc/api/accounts.html
///
/// Object comments are from https://canvas.instructure.com/doc/api/accounts.html documentation
/// </summary>
public interface IAccountsApi
{
    /// <summary>
    /// List accounts
    ///
    /// A paginated list of accounts that the current user can view or manage. Typically, students and even teachers will get an empty list in response, only account admins can view the accounts that they are in.
    /// </summary>
    Task<IEnumerable<Account>> List(params Accountinclude[] include);

    /// <summary>
    /// List accounts for course admins
    ///
    /// A paginated list of accounts that the current user can view through their admin course enrollments. (Teacher, TA, or designer enrollments). Only returns “id”, “name”, “workflow_state”, “root_account_id” and “parent_account_id”
    /// </summary>
    void ListCourseAdminAccounts();

    /// <summary>
    /// Get a single account
    ///
    /// Retrieve information on an individual account, given by id or sis sis_account_id.
    /// </summary>
    /// <param name="accountId">Account Id to get active courses</param>
    void ListActiveCourses(long accountId);

    /// <summary>
    /// Get a single account
    ///
    /// Retrieve information on an individual account, given by id or sis sis_account_id.
    /// </summary>
    /// <param name="accountId"></param>
    Task<IAccount> GetAccount(long accountId);

    /// <summary>
    /// Permissions
    ///
    /// Returns permission information for the calling user and the given account. You may use `self` as the account id to check permissions against the domain root account. The caller must have an account role or admin (teacher/TA/designer) enrollment in a course in the account.
    /// </summary>
    /// <param name="accountId">Account Id to get permissions</param>
    /// <param name="permissions">List of permissions to check against the authenticated user. Permission names are documented in the Create a role endpoint.</param>
    void GetPermission(long accountId, params string[] permissions);
    Task<IEnumerable<Account>> GetSubAccounts(long accountId, bool recursive = false);
        
    Task<IEnumerable<Account>> GetSubAccounts(Account parentAccoun, bool recursive = false);
    void GetTermsOfService(long accountId);
    void GetHelpLinks(long accountId);
    void UpdateAccount(long accountId);
    void DeleteUserFromRootAccount(long accounId, long userId);
    void CreateSubAccount(long accountId);
    void DeleteSubAccount(long accountId, long subAccountId); 
}