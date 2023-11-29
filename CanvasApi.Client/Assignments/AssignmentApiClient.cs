using CanvasApi.Client._Base;
using CanvasApi.Client.Assignments.Models;
using CanvasApi.Client.Extentions;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CanvasApi.Client.Assignments;

internal class AssignmentApiClient : ApiClientBase, IAssignmentApiClient
{
    public AssignmentApiClient(CanvasApiClient parent) : base(parent)
    {
    }

    public async Task<IAssignment> Get(long courseId, long assignmentId, Action<IAssignmentGetOptions> options = null) =>
        await this.ApiClient.ApiOperation<Assignment, IAssignmentGetOptions>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/assignments/{assignmentId}",
            options?.GetOptions<IAssignmentGetOptions, AssignmentGetOptions>() ?? null
        );
}
