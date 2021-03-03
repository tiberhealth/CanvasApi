using System.Collections.Generic;
using System.Threading.Tasks;
using CanvasApi.Client.Submissions.Models;

namespace CanvasApi.Client.Submissions
{
    public interface ISubmissionsApiClient
    {
        /// <summary>
        /// Make a submission for an assignment. You must be enrolled as a student in the course/section to do this.
        ///
        /// All online turn-in submission types are supported in this API.However, there are a few things that are not yet supported:
        ///
        /// Files can be submitted based on a file ID of a user or group file or through the file upload API.However, there is no API yet for listing the user and group files.
        ///
        /// Media comments can be submitted, however, there is no API yet for creating a media comment to submit.
        ///
        /// Integration with Google Docs is not yet supported.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="assignmentId"></param>
        /// <param name="submission"></param>
        /// <returns></returns>
        Task<ISubmission> SubmitCourse(long courseId, long assignmentId, ISubmissionSubmit submission);

        /// <summary>
        /// Make a submission for an assignment. You must be enrolled as a student in the course/section to do this.
        ///
        /// All online turn-in submission types are supported in this API.However, there are a few things that are not yet supported:
        ///
        /// Files can be submitted based on a file ID of a user or group file or through the file upload API.However, there is no API yet for listing the user and group files.
        ///
        /// Media comments can be submitted, however, there is no API yet for creating a media comment to submit.
        ///
        /// Integration with Google Docs is not yet supported.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="assignmentId"></param>
        /// <param name="submission"></param>
        /// <returns></returns>
        Task<ISubmission> SubmitSection(long sectionId, long assignmentId, ISubmissionSubmit submission);

        /// <summary>
        /// A paginated list of all existing submissions for an assignment.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<IEnumerable<ISubmission>> ListCourse(long courseId, long assignmentId, ISubmissionIncludes includes = null);

        /// <summary>
        /// A paginated list of all existing submissions for an assignment.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<IEnumerable<ISubmission>> ListSection(long sectionId, long assignmentId, ISubmissionIncludes includes = null);

        /// <summary>
        /// A paginated list of all existing submissions for an assignment, group By Student Ids
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<IEnumerable<IGroupedSubmissions>> ListCourseGroupedByStudent(long courseId, long assignmentId, ISubmissionIncludes includes = null);

        /// <summary>
        /// A paginated list of all existing submissions for an assignment, group By Student Ids
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<IEnumerable<IGroupedSubmissions>> ListSectionGroupedByStudent(long sectionId, long assignmentId, ISubmissionIncludes includes = null);

        /// <summary>
        /// A paginated list of all existing submissions for a given set of students and assignments.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="listParams"></param>
        /// <returns></returns>
        Task<IEnumerable<ISubmission>> ListCourse(long courseId, ISubmissionListParams listParams);

        /// <summary>
        /// A paginated list of all existing submissions for a given set of students and assignments.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="listParams"></param>
        /// <returns></returns>
        Task<IEnumerable<ISubmission>> ListSection(long sectionId, ISubmissionListParams listParams);

        /// <summary>
        /// A paginated list of all existing submissions for a given set of students and assignments grouped by student.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="listParams"></param>
        /// <returns></returns>
        Task<IEnumerable<IGroupedSubmissions>> ListCourseGroupedByStudent(long courseId, ISubmissionListParams listParams);

        /// <summary>
        /// A paginated list of all existing submissions for a given set of students and assignments grouped by student
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="listParams"></param>
        /// <returns></returns>
        Task<IEnumerable<IGroupedSubmissions>> ListSectionGroupedByStudent(long sectionId, ISubmissionListParams listParams);

        /// <summary>
        /// Get a single submission, based on user id.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="assignmentId"></param>
        /// <param name="userId"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<ISubmission> GetSingleCourse(long courseId, long assignmentId, long userId, ISubmissionIncludes includes = null);

        /// <summary>
        /// Get a single submission, based on user id.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="assignmentId"></param>
        /// <param name="userId"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<ISubmission> GetSingleSection(long sectionId, long assignmentId, long userId, ISubmissionIncludes includes = null);
    }
}
