using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.Enrollments.Enums;
using CanvasApi.Client.Enrollments.Models;
using CanvasApi.Client.Extentions;

namespace CanvasApi.Client.Enrollments
{
    public class EnrollmentApiClient : ApiClientBase, IEnrollmentApiClient
    {
        internal EnrollmentApiClient(CanvasApiClient parent) : base(parent) { }

        public Task<IApiSuccess> AcceptEnrollment(long courseId, long enrollmentId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<IEnrollment>> CourseEnrollments(long courseId, Action<IEnrollmentRequest> options = null) =>
            await this.ApiClient
                .PagableApiOperation<Enrollment, IEnrollmentRequest>(HttpMethod.Get, $"/api/v1/courses/{courseId}/enrollments", options.GetOptions<IEnrollmentRequest, EnrollmentRequest>());

        public Task<IEnrollment> DeactiveEnrollment(long courseId, long enrollmentId, EnrollmentDeactivateTasks task = EnrollmentDeactivateTasks.Conclude)
        {
            throw new NotImplementedException();
        }

        public Task<IEnrollment> EnrollCourseUser(long courseId, IEnrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public Task<IEnrollment> EnrollSection(long sectionId, IEnrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public Task<IEnrollment> GetById(long enrollmentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnrollment> Reactivate(long courseId, long enrollmentId)
        {
            throw new NotImplementedException();
        }

        public Task<IApiSuccess> RejectEnrollment(long courseid, long enrollmentId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<IEnrollment>> SectionEnrollments(long sectionId, Action<IEnrollmentRequest> options = null) =>
            await this.ApiClient.PagableApiOperation<Enrollment, IEnrollmentRequest>(HttpMethod.Get, $"/api/v1/sections/{sectionId}/enrollments", options.GetOptions<IEnrollmentRequest, EnrollmentRequest>());

        public Task<object> SetLastAttended(long courseId, long userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<IEnrollment>> UserEnrollments(long userId, Action<IEnrollmentRequest> options = null) =>
            await this.ApiClient.PagableApiOperation<Enrollment, IEnrollmentRequest>(HttpMethod.Get, $"/api/v1/users/{userId}/enrollments", options.GetOptions<IEnrollmentRequest, EnrollmentRequest>());

    }
}
