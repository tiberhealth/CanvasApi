namespace CanvasApi.Client.Section;

internal class SectionApi : ApiClientBase, ISectionApi
{
    public SectionApi(CanvasApiClient parent) : base(parent)
    {
    }

    public async Task<ICourseSection> Get(long courseId, long sectionId) =>
        await this.ApiClient.ApiOperation<CourseSection>(HttpMethod.Get, $"/api/v1/courses/{courseId}/sections/{sectionId}");
    public async Task<ICourseSection> Get(long sectionId) =>
        await this.ApiClient.ApiOperation<CourseSection>(HttpMethod.Get, $"/api/v1/sections/{sectionId}");

    public async Task<IEnumerable<ICourseSection>> List(long courseId) =>
        await this.ApiClient.PagableApiOperation<CourseSection>(HttpMethod.Get, $"/api/v1/courses/{courseId}/sections");

}
