namespace CanvasApi.Client.Submissions;

internal class SubmissionsApiClient : ApiClientBase, ISubmissionsApiClient
{
    public SubmissionsApiClient(CanvasApiClient parent) : base(parent) { }

    public async Task<ISubmission> GetSingleCourse(long courseId, long assignmentId, long userId, Action<ISubmissionIncludes> includes = null) =>
        await this.ApiClient.ApiOperation<Submission, ISubmissionIncludes>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/assignments/{assignmentId}/submissions/{userId}",
            includes.GetOptions<ISubmissionIncludes, SubmissionIncludes>()
        );

    public async Task<ISubmission> GetSingleSection(long sectionId, long assignmentId, long userId, Action<ISubmissionIncludes> includes = null) =>
        await this.ApiClient.ApiOperation<Submission, ISubmissionIncludes>(
            HttpMethod.Get,
            $"/api/v1/sections/{sectionId}/assignments/{assignmentId}/submissions/{userId}",
            includes.GetOptions<ISubmissionIncludes, SubmissionIncludes>()
        );

    public async Task<IEnumerable<ISubmission>> ListCourse(long courseId, long assignmentId, Action<ISubmissionIncludes> includes = null) =>
        await this.ApiClient.PagableApiOperation<Submission, ISubmissionIncludes>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/assignments/{assignmentId}/submissions",
            includes.GetOptions<ISubmissionIncludes, SubmissionIncludes>()
        );

    public async Task<IEnumerable<ISubmission>> ListCourse(long courseId, Action<ISubmissionListParams> listParams) =>
        await this.ApiClient.PagableApiOperation<Submission, ISubmissionListParams>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/students/submissions",
            listParams.GetOptions<ISubmissionListParams, SubmissionListParams>()
        );


    public async Task<IEnumerable<IGroupedSubmissions>> ListCourseGroupedByStudent(long courseId, long assignmentId, Action<ISubmissionIncludes> includes = null) =>
        await this.ApiClient.PagableApiOperation<GroupedSubmissions, ISubmissionIncludes>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/assignments/{assignmentId}/submissions",
            includes.GetOptions<ISubmissionIncludes, SubmissionIncludes>(o => o.Grouped = true)
        );

    public async Task<IEnumerable<IGroupedSubmissions>> ListCourseGroupedByStudent(long courseId, Action<ISubmissionListParams> listParams) =>
        await this.ApiClient.PagableApiOperation<GroupedSubmissions, ISubmissionListParams>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/students/submissions",
            listParams.GetOptions<ISubmissionListParams, SubmissionListParams>(o => o.Grouped = true)
        );

    public async Task<IEnumerable<ISubmission>> ListSection(long sectionId, long assignmentId, Action<ISubmissionIncludes> includes = null) =>
        await this.ApiClient.PagableApiOperation<Submission, ISubmissionIncludes>(
            HttpMethod.Get,
            $"/api/v1/sections/{sectionId}/assignments/{assignmentId}/submissions",
            includes.GetOptions<ISubmissionIncludes, SubmissionIncludes>()
        );

    public async Task<IEnumerable<ISubmission>> ListSection(long sectionId, Action<ISubmissionListParams> listParams) =>
        await this.ApiClient.PagableApiOperation<Submission, ISubmissionListParams>(
            HttpMethod.Get,
            $"/api/v1/sections/{sectionId}/students/submissions",
            listParams.GetOptions<ISubmissionListParams, SubmissionListParams>()
        );

    public async Task<IEnumerable<IGroupedSubmissions>> ListSectionGroupedByStudent(long sectionId, long assignmentId, Action<ISubmissionIncludes> includes = null) =>
        await this.ApiClient.PagableApiOperation<GroupedSubmissions, ISubmissionIncludes>(
            HttpMethod.Get,
            $"/api/v1/sections/{sectionId}/assignments/{assignmentId}/submissions",
            includes.GetOptions<ISubmissionIncludes, SubmissionIncludes>(o => o.Grouped = true)
        );

    public async Task<IEnumerable<IGroupedSubmissions>> ListSectionGroupedByStudent(long sectionId, Action<ISubmissionListParams> listParams) =>
        await this.ApiClient.PagableApiOperation<GroupedSubmissions, ISubmissionListParams>(
            HttpMethod.Get,
            $"/api/v1/sections/{sectionId}/students/submissions",
            listParams.GetOptions<ISubmissionListParams, SubmissionListParams>(o => o.Grouped = true)
        );
        

    public async Task<ISubmission> SubmitCourse(long courseId, long assignmentId, Action<ISubmissionSubmit> submission) =>
        await this.ApiClient.ApiOperation<Submission, ISubmissionSubmit>(
            HttpMethod.Post,
            $"/api/v1/courses/{courseId}/assignments/{assignmentId}/submissions",
            submission.GetOptions<ISubmissionSubmit, SubmissionSubmit>()
        );

    public async Task<ISubmission> SubmitSection(long sectionId, long assignmentId, Action<ISubmissionSubmit> submission) =>
        await this.ApiClient.ApiOperation<Submission, ISubmissionSubmit>(
            HttpMethod.Post,
            $"/api/v1/sections/{sectionId}/assignments/{assignmentId}/submissions",
            submission.GetOptions<ISubmissionSubmit, SubmissionSubmit>()
        );

}