namespace CanvasApi.Client.Assignments;

internal class AssignmentApiClient(CanvasApiClient parent) : ApiClientBase(parent), IAssignmentApiClient
{
    public async Task<IEnumerable<IAssignment>> List(long courseId) =>
        await this.ApiClient.PagableApiOperation<Assignment>(HttpMethod.Get, $"/api/v1/courses/{courseId}/assignments");

    public async Task<IAssignment> Get(long courseId, long assignmentId, Action<IAssignmentGetOptions> options = null) =>
        await this.ApiClient.ApiOperation<Assignment, IAssignmentGetOptions>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/assignments/{assignmentId}",
            options?.GetOptions<IAssignmentGetOptions, AssignmentGetOptions>() ?? null
        );
}
