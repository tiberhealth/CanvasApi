using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CanvasApi.Client.Enrollments.Enums;
using CanvasApi.Client.Enrollments.Models;

namespace CanvasApi.Client.Enrollments
{
    public interface IEnrollmentApiClient
    {
        /// <summary>
        /// List enrollments
        ///
        /// Depending on the URL given, return a paginated list of either (1) all of the enrollments in a course, (2) all of the enrollments in a section or (3) all of a user's enrollments. This includes student, teacher, TA, and observer enrollments.
        /// If a user has multiple enrollments in a context(e.g. as a teacher and a student or in multiple course sections), each enrollment will be listed separately.
        /// 
        /// note: Currently, only a root level admin user can return other users' enrollments. A user can, however, return his/her own enrollments.
        /// 
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<IEnumerable<IEnrollment>> CourseEnrollments(long courseId, Action<IEnrollmentRequest> options = null);
        /// <summary>
        /// List enrollments
        ///
        /// Depending on the URL given, return a paginated list of either (1) all of the enrollments in a course, (2) all of the enrollments in a section or (3) all of a user's enrollments. This includes student, teacher, TA, and observer enrollments.
        /// If a user has multiple enrollments in a context(e.g. as a teacher and a student or in multiple course sections), each enrollment will be listed separately.
        /// 
        /// note: Currently, only a root level admin user can return other users' enrollments. A user can, however, return his/her own enrollments.
        /// 
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<IEnumerable<IEnrollment>> SectionEnrollments(long sectionId, Action<IEnrollmentRequest> options = null);
        /// <summary>
        /// List enrollments
        ///
        /// Depending on the URL given, return a paginated list of either (1) all of the enrollments in a course, (2) all of the enrollments in a section or (3) all of a user's enrollments. This includes student, teacher, TA, and observer enrollments.
        /// If a user has multiple enrollments in a context(e.g. as a teacher and a student or in multiple course sections), each enrollment will be listed separately.
        /// 
        /// note: Currently, only a root level admin user can return other users' enrollments. A user can, however, return his/her own enrollments.
        /// 
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<IEnumerable<IEnrollment>> UserEnrollments(long userId, Action<IEnrollmentRequest> options = null);
        /// <summary>
        /// Get an Enrollment object by Enrollment ID
        /// </summary>
        /// <param name="enrollmentId"></param>
        /// <returns></returns>
        Task<IEnrollment> GetById(long enrollmentId);
        /// <summary>
        /// Create a new user enrollment for a course or section.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="enrollment"></param>
        /// <returns></returns>
        Task<IEnrollment> EnrollCourseUser(long courseId, IEnrollment enrollment);
        /// <summary>
        /// Create a new user enrollment for a course or section.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="enrollment"></param>
        /// <returns></returns>
        Task<IEnrollment> EnrollSection(long sectionId, IEnrollment enrollment);
        /// <summary>
        /// Conclude, deactivate, or delete an enrollment. If the task argument isn't given, the enrollment will be concluded.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="enrollmentId"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        Task<IEnrollment> DeactiveEnrollment(long courseId, long enrollmentId, EnrollmentDeactivateTasks task = EnrollmentDeactivateTasks.Conclude);
        /// <summary>
        /// accepts a pending course invitation for the current user
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="enrollmentId"></param>
        /// <returns></returns>
        Task<IApiSuccess> AcceptEnrollment(long courseId, long enrollmentId);
        /// <summary>
        /// rejects a pending course invitation for the current user
        /// </summary>
        /// <param name="courseid"></param>
        /// <param name="enrollmentId"></param>
        /// <returns></returns>
        Task<IApiSuccess> RejectEnrollment(long courseid, long enrollmentId);
        /// <summary>
        /// Activates an inactive enrollment
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="enrollmentId"></param>
        /// <returns></returns>
        Task<IEnrollment> Reactivate(long courseId, long enrollmentId);
        /// <summary>
        /// Adds last attended date to student enrollment in course
        /// (Canvas Documentation looks to be incomplete for this call)
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<object> SetLastAttended(long courseId, long userId);
    }
}
