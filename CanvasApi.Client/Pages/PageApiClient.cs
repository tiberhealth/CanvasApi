using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.Pages.Enums;
using CanvasApi.Client.Pages.Models;
using CanvasApi.Client.Pages.Models.Concrete;

namespace CanvasApi.Client.Pages
{
    public class PageApiClient : ApiClientBase, IPageApiClient
    {
        public PageApiClient(CanvasApiClient parent) : base(parent) { }

        public Task<IPage> Create(long id, Action<IWikiPage> pageFactory, CourseGroupFlag type = CourseGroupFlag.Course) =>
            this.ProcessWiki(HttpMethod.Post, $"/api/v1/{Api(type)}/{id}/pages", pageFactory);

        public async Task<IPage> Delete(long id, string url, CourseGroupFlag type = CourseGroupFlag.Course) =>
            await this.ApiClient.ApiOperation<Page>(HttpMethod.Delete, $"/api/v1/{Api(type)}/pages/{url}");

        public async Task<IPage> Duplicate(long courseId, string url) =>
            await this.ApiClient.ApiOperation<Page>(HttpMethod.Post, $"/api/v1/courses/{courseId}/pages/{url}/duplicate");

        public async Task<IPage> FrontPage(long id, CourseGroupFlag type = CourseGroupFlag.Course) =>
            await this.ApiClient.ApiOperation<Page>(HttpMethod.Get, $"/api/v1/{Api(type)}/front_page");

        public async Task<IEnumerable<IPage>> List(long id, Action<IListOptions> optionsFactory = null, CourseGroupFlag type = CourseGroupFlag.Course)
        {
            var listOptions = new ListOptions();
            optionsFactory?.Invoke(listOptions);

            return await this.ApiClient.PagableApiOperation<Page, IListOptions>(HttpMethod.Get, $"/api/v1/{Api(type)}/{id}/pages", listOptions);
        }

        public async Task<IEnumerable<IPageRevision>> ListRevisions(long id, string url, CourseGroupFlag type = CourseGroupFlag.Course) =>
            await this.ApiClient.PagableApiOperation<PageRevision>(HttpMethod.Get, $"/api/v1/{Api(type)}/{id}/pages/{url}/revisions");

        public async Task<IPageRevision> Revert(long id, string url, long revisionId, CourseGroupFlag type = CourseGroupFlag.Course) =>
            await this.ApiClient.ApiOperation<PageRevision>(HttpMethod.Post, $"/api/v1/{Api(type)}/{id}/pages/{url}/revisions/{revisionId}");

        public async Task<IPage> Show(long id, string url, CourseGroupFlag type = CourseGroupFlag.Course) =>
            await this.ApiClient.ApiOperation<Page>(HttpMethod.Get, $"/api/v1/{Api(type)}/{id}/pages/{url}");

        public async Task<IPageRevision> ShowRevision(long id, string url, long? revisionId, bool? summary, CourseGroupFlag type = CourseGroupFlag.Course)
        {
            var apiUrl = $"/api/v1/{Api(type)}/{id}/pages/{url}/revisions/{revisionId?.ToString() ?? "latest"}";
            if (summary.HasValue) apiUrl += $"?summary={summary.Value}";

            return await this.ApiClient.ApiOperation<PageRevision>(HttpMethod.Get, apiUrl);
        }

        public Task<IPage> UpdateFontPage(long id, Action<IWikiPage> pageFactory, CourseGroupFlag type = CourseGroupFlag.Course) =>
            this.ProcessWiki(HttpMethod.Put, $"/api/v1/{Api(type)}/{id}/front_page", pageFactory);
   

        public Task<IPage> UpdatePage(long id, string url, Action<IWikiPage> pageFactory, CourseGroupFlag type = CourseGroupFlag.Course) =>
            this.ProcessWiki(HttpMethod.Put, $"/api/v1/{Api(type)}/{id}/pages/{url}", pageFactory);

        private string Api(CourseGroupFlag type) => type switch
        {
            CourseGroupFlag.Group => "groups",
            _ => "courses"
        };

        private async Task<IPage> ProcessWiki(HttpMethod method, string url, Action<IWikiPage> wikiFactory)
        {
            var wiki = new WikiPage();
            wikiFactory?.Invoke(wiki);

            return await this.ApiClient.ApiOperation<Page, IWikiPage>(method, url, wiki);
        }

    }
}
