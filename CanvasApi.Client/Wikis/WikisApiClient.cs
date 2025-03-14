﻿namespace CanvasApi.Client.Wikis;

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
