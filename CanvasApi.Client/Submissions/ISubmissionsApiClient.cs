using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CanvasApi.Client.Submissions.Models;
namespace CanvasApi.Client.Submissions;

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
    Task<ISubmission> SubmitCourse(long courseId, long assignmentId, Action<ISubmissionSubmit> submission);

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
    Task<ISubmission> SubmitSection(long sectionId, long assignmentId,Action<ISubmissionSubmit> submission);

    /// <summary>
    /// A paginated list of all existing submissions for an assignment.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="includes"></param>
    /// <returns></returns>
    Task<IEnumerable<ISubmission>> ListCourse(long courseId, long assignmentId, Action<ISubmissionIncludes> includes = null);

    /// <summary>
    /// A paginated list of all existing submissions for an assignment.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="includes"></param>
    /// <returns></returns>
    Task<IEnumerable<ISubmission>> ListSection(long sectionId, long assignmentId, Action<ISubmissionIncludes> includes = null);

    /// <summary>
    /// A paginated list of all existing submissions for an assignment, group By Student Ids
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="includes"></param>
    /// <returns></returns>
    Task<IEnumerable<IGroupedSubmissions>> ListCourseGroupedByStudent(long courseId, long assignmentId, Action<ISubmissionIncludes> includes = null);

    /// <summary>
    /// A paginated list of all existing submissions for an assignment, group By Student Ids
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="includes"></param>
    /// <returns></returns>
    Task<IEnumerable<IGroupedSubmissions>> ListSectionGroupedByStudent(long sectionId, long assignmentId, Action<ISubmissionIncludes> includes = null);

    /// <summary>
    /// A paginated list of all existing submissions for a given set of students and assignments.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="listParams"></param>
    /// <returns></returns>
    Task<IEnumerable<ISubmission>> ListCourse(long courseId, Action<ISubmissionListParams> listParams);

    /// <summary>
    /// A paginated list of all existing submissions for a given set of students and assignments.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="listParams"></param>
    /// <returns></returns>
    Task<IEnumerable<ISubmission>> ListSection(long sectionId, Action<ISubmissionListParams> listParams);

    /// <summary>
    /// A paginated list of all existing submissions for a given set of students and assignments grouped by student.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="listParams"></param>
    /// <returns></returns>
    Task<IEnumerable<IGroupedSubmissions>> ListCourseGroupedByStudent(long courseId, Action<ISubmissionListParams> listParams);

    /// <summary>
    /// A paginated list of all existing submissions for a given set of students and assignments grouped by student
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="listParams"></param>
    /// <returns></returns>
    Task<IEnumerable<IGroupedSubmissions>> ListSectionGroupedByStudent(long sectionId, Action<ISubmissionListParams> listParams);

    /// <summary>
    /// Get a single submission, based on user id.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="assignmentId"></param>
    /// <param name="userId"></param>
    /// <param name="includes"></param>
    /// <returns></returns>
    Task<ISubmission> GetSingleCourse(long courseId, long assignmentId, long userId, Action<ISubmissionIncludes> includes = null);

    /// <summary>
    /// Get a single submission, based on user id.
    /// </summary>
    /// <param name="sectionId"></param>
    /// <param name="assignmentId"></param>
    /// <param name="userId"></param>
    /// <param name="includes"></param>
    /// <returns></returns>
    Task<ISubmission> GetSingleSection(long sectionId, long assignmentId, long userId, Action<ISubmissionIncludes> includes = null);

    /// <summary>
    /// Grade (or comment on) a single submission.
    /// Wraps Canvas API:
    ///     PUT /api/v1/courses/:course_id/assignments/:assignment_id/submissions/:user_id
    ///
    /// Builds a body like:
    ///     submission[posted_grade]=85.5%
    ///     submission[excuse]=false
    ///     comment[text_comment]=...        (optional)
    /// </summary>
    /// <param name="courseId">The course id.</param>
    /// <param name="assignmentId">The assignment id.</param>
    /// <param name="userId">The Canvas user id being graded.</param>
    /// <param name="grade">Builder for the grading fields. Use <c>g.PostedGrade = "85.5%"</c>
    /// (or a numeric string for points grading).</param>
    /// <param name="comment">Optional builder for an attached grader comment.</param>
    /// <param name="cancellationToken">Cancellation token for the underlying HTTP request.</param>
    /// <returns>The updated submission as returned by Canvas.</returns>
    Task<ISubmission> Grade(
        long courseId,
        long assignmentId,
        long userId,
        Action<ISubmissionGradeDetail> grade,
        Action<ISubmissionSubmitComment> comment = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Grade (or comment on) a single submission, using a section context instead of a course context.
    /// Wraps Canvas API:
    ///     PUT /api/v1/sections/:section_id/assignments/:assignment_id/submissions/:user_id
    /// </summary>
    Task<ISubmission> GradeSection(
        long sectionId,
        long assignmentId,
        long userId,
        Action<ISubmissionGradeDetail> grade,
        Action<ISubmissionSubmitComment> comment = null,
        CancellationToken cancellationToken = default);
}