using CanvasApi.Client._Base;
using CanvasApi.Client.Assignments.Models;
using CanvasApi.Client.Pages.Models;
using System.Net.Http;
using System;
using System.Threading.Tasks;

namespace CanvasApi.Client.Wikis;

internal class WikisApiClient : ApiClientBase, IWikisApiClient
{
    public WikisApiClient(CanvasApiClient parent) : base(parent)
    {
    }

    public async Task<IPage> Get(long courseId, string pageUrlOrId) => 
        await this.ApiClient.ApiOperation<Page>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/pages/{pageUrlOrId}"
        );
}
