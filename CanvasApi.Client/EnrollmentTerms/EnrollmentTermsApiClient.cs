namespace CanvasApi.Client.EnrollmentTerms;

internal class EnrollmentTermsApiClient(CanvasApiClient parent) : ApiClientBase(parent), IEnrollmentTermsApiClient {
    public async Task<IEnrollmentTerm> Create(long accountId, Action<IEnrollmentTermDetail> enrollmentTerm) =>
        await this.ApiClient.ApiOperation<EnrollmentTerm, IEnrollmentTermNewUpdate>(
            HttpMethod.Post,
            $"/api/v1/accounts/{accountId}/terms",
            new EnrollmentTermNewUpdate { EnrollmentTerm = enrollmentTerm.GetOptions<IEnrollmentTermDetail, EnrollmentTermDetail>() }
        );

    public async Task<IEnrollmentTerm> Delete(long accountId, long id) =>
        await this.ApiClient.ApiOperation<EnrollmentTerm>(
            HttpMethod.Delete,
            $"/api/v1/accounts/{accountId}/terms/{id}"
        );

    public async Task<IEnumerable<IEnrollmentTerm>> List(long accountId, Action<IEnrollmentTermListOptions> options = null) =>
        await this.ApiClient.PagableApiOperation<EnrollmentTerm, EnrollmentTermsListResult, IEnrollmentTermListOptions>(
            HttpMethod.Get,
            $"/api/v1/accounts/{accountId}/terms",
            null,
            EnrollmentTermsListResult.ToArray);

    public async Task<IEnrollmentTerm> Retrieve(long accountId, long id, Action<IEnrollmentTermRetrieveOptions> options = null) =>
        await this.ApiClient.ApiOperation<EnrollmentTerm, IEnrollmentTermRetrieveOptions>(
            HttpMethod.Get,
            $"/api/v1/accounts/{accountId}/terms/{id}",
            null
        );

    public async Task<IEnrollmentTerm> Update(long accountId, long id, Action<IEnrollmentTermDetail> enrollmentTerm) =>
        await this.ApiClient.ApiOperation<EnrollmentTerm, IEnrollmentTermNewUpdate>(
            HttpMethod.Put,
            $"/api/v1/accounts/{accountId}/terms/{id}",
            new EnrollmentTermNewUpdate { EnrollmentTerm = enrollmentTerm.GetOptions<IEnrollmentTermDetail, EnrollmentTermDetail>() }
        );
}
