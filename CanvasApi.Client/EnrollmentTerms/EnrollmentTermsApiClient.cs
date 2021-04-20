using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.EnrollmentTerms.Models;
using CanvasApi.Client.Extentions;

namespace CanvasApi.Client.EnrollmentTerms
{
    public class EnrollmentTermsApiClient : ApiClientBase, IEnrollmentTermsApiClient
    {
        public EnrollmentTermsApiClient(CanvasApiClient parent) : base(parent) { }

        public async Task<IEnrollmentTerm> Create(long accountId, Action<IEnrollmentTermNewUpdate> enrollmentTerm) =>
            await this.ApiClient.ApiOperation<EnrollmentTerm, IEnrollmentTermNewUpdate>(
                HttpMethod.Get,
                $"/api/v1/accounts/{accountId}/terms",
                enrollmentTerm.GetOptions<IEnrollmentTermNewUpdate, EnrollmentTermNewUpdate>()
                );

        public async Task<IEnrollmentTerm> Delete(long accountId, long Id) =>
            await this.ApiClient.ApiOperation<EnrollmentTerm>(
                HttpMethod.Delete,
                $"/api/v1/accounts/{accountId}/terms/{Id}"
                );

        public async Task<IEnumerable<IEnrollmentTerm>> List(long accountId, Action<IEnrollmentTermListOptions> options = null) =>
            await this.ApiClient.PagableApiOperation<EnrollmentTerm, IEnrollmentTermListOptions>(
               HttpMethod.Get,
               $"/api/v1/accounts/{accountId}/terms",
               options.GetOptions<IEnrollmentTermListOptions, EnrollmentTermListOptions>()
               );

        public async Task<IEnrollmentTerm> Retrieve(long accountId, long Id, Action<IEnrollmentTermRetrieveOptions> options = null) =>
            await this.ApiClient.ApiOperation<EnrollmentTerm, IEnrollmentTermRetrieveOptions>(
                HttpMethod.Get,
                $"/api/v1/accounts/{accountId}/terms/{Id}",
                options.GetOptions<IEnrollmentTermRetrieveOptions, EnrollmentTermRetrieveOptions>()
                );

        public async Task<IEnrollmentTerm> Update(long accountId, long Id, Action<IEnrollmentTermNewUpdate> enrollmentTerm) =>
            await this.ApiClient.ApiOperation<EnrollmentTerm, IEnrollmentTermNewUpdate>(
                HttpMethod.Put,
                $"/api/v1/accounts/{accountId}/terms/{Id}",
                enrollmentTerm.GetOptions<IEnrollmentTermNewUpdate, EnrollmentTermNewUpdate>()
                );
    }
}
