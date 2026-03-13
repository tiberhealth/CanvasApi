namespace CanvasApi.Client.Assignments;

public interface IAssignmentApiClient
{
    Task<IEnumerable<IAssignment>> List(long courseId);
    Task<IAssignment> Get(long courseId, long assignmentId, Action<IAssignmentGetOptions> options = null);

}
