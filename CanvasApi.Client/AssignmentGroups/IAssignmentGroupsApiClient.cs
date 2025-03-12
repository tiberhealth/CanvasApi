namespace CanvasApi.Client.AssignmentGroups;

public interface IAssignmentGroupsApiClient
{
    /// <summary>
    /// Returns the paginated list of assignment groups for the current context. The returned groups are sorted by their position field
    /// </summary>
    /// <param name="courseId"></param>
    /// <returns></returns>
    Task<IEnumerable<IAssignmentGroup>> List(long courseId, Action<IAssignmentGroupListOptions> options = null);

    /// <summary>
    /// Returns the assignment group with the given id
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="assignmentGroupId"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    Task<IAssignmentGroup> Get(long courseId, long assignmentGroupId, Action<IAssignmentGroupGetOptions> options = null);

    /// <summary>
    /// Create a new assignment group for this course
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="assignmentGroup"></param>
    /// <returns></returns>
    Task<IAssignmentGroup> Create(long courseId, Action<IAssignmentGroupNewEdit> assignmentGroup);

    /// <summary>
    /// Modify an existing Assignment Group. Accepts the same parameters as Assignment Group creation
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="assignmentGroup"></param>
    /// <returns></returns>
    Task<IAssignmentGroup> Edit(long courseId, long assignmentGroupId, Action<IAssignmentGroupNewEdit> assignmentGroup);

    /// <summary>
    /// Deletes the assignment group with the given id.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="assignmentGroupId"></param>
    /// <returns></returns>
    Task<IAssignmentGroup> Destroy(long courseId, long assignmentGroupId, Action<IDeleteAssignmentGroup> body = null);
}