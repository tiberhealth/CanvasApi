using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CanvasApi.Client.Assignments.Models;

namespace CanvasApi.Client.Assignments;

public interface IAssignmentApiClient
{
    /// <summary>
    /// Lists all assignments for a course.
    /// </summary>
    Task<IEnumerable<IAssignment>> List(long courseId);

    /// <summary>
    /// Gets a single assignment by id.
    /// </summary>
    Task<IAssignment> Get(long courseId, long assignmentId, Action<IAssignmentGetOptions> options = null);

    /// <summary>
    /// Creates a new assignment on the given course.
    /// Wraps Canvas API:
    ///     POST /api/v1/courses/:course_id/assignments
    /// </summary>
    /// <param name="courseId">The course to create the assignment in.</param>
    /// <param name="assignment">Builder for the assignment fields (Name, PointsPossible, AssignmentGroupId, etc.).</param>
    /// <param name="cancellationToken">Cancellation token for the underlying HTTP request.</param>
    /// <returns>The newly-created assignment as returned by Canvas.</returns>
    Task<IAssignment> Create(long courseId, Action<IAssignmentNewEdit> assignment, CancellationToken cancellationToken = default);

    /// <summary>
    /// Edits an existing assignment.
    /// Wraps Canvas API:
    ///     PUT /api/v1/courses/:course_id/assignments/:id
    /// </summary>
    Task<IAssignment> Edit(long courseId, long assignmentId, Action<IAssignmentNewEdit> assignment, CancellationToken cancellationToken = default);
}
