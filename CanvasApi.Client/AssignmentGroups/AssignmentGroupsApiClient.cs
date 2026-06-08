namespace CanvasApi.Client.AssignmentGroups;

internal class AssignmentGroupsApiClient : ApiClientBase, IAssignmentGroupsApiClient
{
    public AssignmentGroupsApiClient(CanvasApiClient parent) : base(parent) { }

    public async Task<IAssignmentGroup> Create(long courseId, Action<IAssignmentGroupNewEdit> assignmentGroup) =>
        await this.ApiClient.ApiOperation<AssignmentGroup, IAssignmentGroupNewEdit>(
            HttpMethod.Post,
            $"/api/v1/courses/{courseId}/assignment_groups",
            assignmentGroup.GetOptions<IAssignmentGroupNewEdit, AssignmentGroupNewEdit>()
        );

    public async Task<IAssignmentGroup> Destroy(long courseId, long assignmentGroupId, Action<IDeleteAssignmentGroup> body) =>
        await this.ApiClient.ApiOperation<AssignmentGroup, IDeleteAssignmentGroup>(
            HttpMethod.Delete,
            $"/api/v1/courses/{courseId}/assignment_groups/{assignmentGroupId}",
            body.GetOptions<IDeleteAssignmentGroup, DeleteAssignmentGroup>()
        );

    public async Task<IAssignmentGroup> Edit(long courseId, long assignmentGroupId, Action<IAssignmentGroupNewEdit> assignmentGroup) =>
        await this.ApiClient.ApiOperation<AssignmentGroup, IAssignmentGroupNewEdit>(
            HttpMethod.Put,
            $"/api/v1/courses/{courseId}/assignment_groups/{assignmentGroupId}",
            assignmentGroup.GetOptions<IAssignmentGroupNewEdit, AssignmentGroupNewEdit>()
        );

    public async Task<IAssignmentGroup> Get(long courseId, long assignmentGroupId, Action<IAssignmentGroupGetOptions> options = null) =>
        await this.ApiClient.ApiOperation<AssignmentGroup, IAssignmentGroupGetOptions>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/assignment_groups/{assignmentGroupId}",
            options.GetOptions<IAssignmentGroupGetOptions, AssignmentGroupGetOptions>()
        );

    public async Task<IEnumerable<IAssignmentGroup>> List(long courseId, Action<IAssignmentGroupListOptions> options = null) =>
        await this.ApiClient.PagableApiOperation<AssignmentGroup, IAssignmentGroupListOptions>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/assignment_groups",
            options.GetOptions<IAssignmentGroupListOptions, AssignmentGroupListOptions>()
        );
}