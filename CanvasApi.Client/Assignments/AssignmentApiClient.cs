using CanvasApi.Client._Base;
using CanvasApi.Client.Assignments.Models;
using CanvasApi.Client.Extentions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CanvasApi.Client.Assignments;

internal class AssignmentApiClient(CanvasApiClient parent) : ApiClientBase(parent), IAssignmentApiClient
{
    public async Task<IEnumerable<IAssignment>> List(long courseId) =>
        await this.ApiClient.PagableApiOperation<Assignment>(HttpMethod.Get, $"/api/v1/courses/{courseId}/assignments");

    public async Task<IEnumerable<IAssignment>> List(long courseId) =>
        await this.ApiClient.PagableApiOperation<Assignment>(HttpMethod.Get, $"/api/v1/courses/{courseId}/assignments");

    public async Task<IAssignment> Get(long courseId, long assignmentId, Action<IAssignmentGetOptions> options = null) =>
        await this.ApiClient.ApiOperation<Assignment, IAssignmentGetOptions>(
            HttpMethod.Get,
            $"/api/v1/courses/{courseId}/assignments/{assignmentId}",
            options?.GetOptions<IAssignmentGetOptions, AssignmentGetOptions>() ?? null
        );

    public async Task<IAssignment> Create(long courseId, Action<IAssignmentNewEdit> assignment, CancellationToken cancellationToken = default) =>
        await this.ApiClient.ApiOperation<Assignment, IAssignmentCreate>(
            HttpMethod.Post,
            $"/api/v1/courses/{courseId}/assignments",
            BuildAssignmentBody(assignment),
            cancellationToken: cancellationToken
        );

    public async Task<IAssignment> Edit(long courseId, long assignmentId, Action<IAssignmentNewEdit> assignment, CancellationToken cancellationToken = default) =>
        await this.ApiClient.ApiOperation<Assignment, IAssignmentCreate>(
            HttpMethod.Put,
            $"/api/v1/courses/{courseId}/assignments/{assignmentId}",
            BuildAssignmentBody(assignment),
            cancellationToken: cancellationToken
        );

    /// <summary>
    /// Wraps the caller's inner-field builder in an <see cref="IAssignmentCreate"/>
    /// so the multipart serializer emits the required <c>assignment[*]</c> prefix
    /// on the wire.
    /// </summary>
    private static IAssignmentCreate BuildAssignmentBody(Action<IAssignmentNewEdit> assignment)
    {
        var wrapper = new AssignmentCreate { Assignment = new AssignmentNewEdit() };
        assignment?.Invoke(wrapper.Assignment);
        return wrapper;
    }
}
