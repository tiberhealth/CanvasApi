namespace CanvasApi.Client.EnrollmentTerms;

public interface IEnrollmentTermsApiClient
{
    /// <summary>
    /// Create a new enrollment term for the specified account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="enrollmentTerm"></param>
    /// <returns></returns>
    Task<IEnrollmentTerm> Create(long accountId, Action<IEnrollmentTermDetail> enrollmentTerm);

    /// <summary>
    /// Update an existing enrollment term for the specified account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="id"></param>
    /// <param name="enrollmentTerm"></param>
    /// <returns></returns>
    Task<IEnrollmentTerm> Update(long accountId, long id, Action<IEnrollmentTermDetail> enrollmentTerm);

    /// <summary>
    /// Delete the specified enrollment term.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<IEnrollmentTerm> Delete(long accountId, long id);

    /// <summary>
    /// An object with a paginated list of all the terms in the account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    Task<IEnumerable<IEnrollmentTerm>> List(long accountId, Action<IEnrollmentTermListOptions> options = null);

    /// <summary>
    /// Update an existing enrollment term for the specified account.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="id"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    Task<IEnrollmentTerm> Retrieve(long accountId, long id, Action<IEnrollmentTermRetrieveOptions> options = null);
}
