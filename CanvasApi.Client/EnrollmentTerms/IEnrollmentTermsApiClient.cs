using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CanvasApi.Client.EnrollmentTerms.Models;

namespace CanvasApi.Client.EnrollmentTerms
{
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
        /// <param name="Id"></param>
        /// <param name="enrollmentTerm"></param>
        /// <returns></returns>
        Task<IEnrollmentTerm> Update(long accountId, long Id, Action<IEnrollmentTermDetail> enrollmentTerm);

        /// <summary>
        /// Delete the specified enrollment term.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<IEnrollmentTerm> Delete(long accountId, long Id);

        /// <summary>
        /// An object with a paginated list of all of the terms in the account.
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task<IEnumerable<IEnrollmentTerm>> List(long accountId, Action<IEnrollmentTermListOptions> options = null);

        /// <summary>
        /// Update an existing enrollment term for the specified account.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="Id"></param>
        /// <param name="enrollmentTerm"></param>
        /// <returns></returns>
        Task<IEnrollmentTerm> Retrieve(long accountId, long Id, Action<IEnrollmentTermRetrieveOptions> options = null);
    }
}
