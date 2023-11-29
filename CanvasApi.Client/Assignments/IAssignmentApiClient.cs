using System;
using System.Threading.Tasks;
using CanvasApi.Client.Assignments.Models;

namespace CanvasApi.Client.Assignments;

public interface IAssignmentApiClient
{
    Task<IAssignment> Get(long courseId, long assignmentId, Action<IAssignmentGetOptions> options = null);

}
