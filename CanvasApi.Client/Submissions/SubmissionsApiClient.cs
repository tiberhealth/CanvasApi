using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.Submissions.Models;

namespace CanvasApi.Client.Submissions
{
    public class SubmissionsApiClient : ApiClientBase, ISubmissionsApiClient
    {
        public SubmissionsApiClient(CanvasApiClient parent) : base(parent) { }

        public async Task<ISubmission> GetSingleCourse(long courseId, long assignmentId, long userId, ISubmissionIncludes includes = null) =>
            await this.ApiClient.ApiOperation<Submission, ISubmissionIncludes>(
                    HttpMethod.Get,
                    $"/api/v1/courses/{courseId}/assignments/{assignmentId}/submissions/{userId}",
                    includes
                );

        public async Task<ISubmission> GetSingleSection(long sectionId, long assignmentId, long userId, ISubmissionIncludes includes = null) =>
            await this.ApiClient.ApiOperation<Submission, ISubmissionIncludes>(
                    HttpMethod.Get,
                    $"/api/v1/sections/{sectionId}/assignments/{assignmentId}/submissions/{userId}",
                    includes
                );

        public async Task<IEnumerable<ISubmission>> ListCourse(long courseId, long assignmentId, ISubmissionIncludes includes = null) =>
            await this.ApiClient.PagableApiOperation<Submission, SubmissionIncludes>(
                    HttpMethod.Get,
                    $"/api/v1/courses/{courseId}/assignments/{assignmentId}/submissions",
                    SubmissionIncludes.Get(includes)
                );

        public async Task<IEnumerable<ISubmission>> ListCourse(long courseId, ISubmissionListParams listParams) =>
            await this.ApiClient.PagableApiOperation<Submission, ISubmissionListParams>(
                    HttpMethod.Get,
                    $"/api/v1/courses/{courseId}/students/submissions",
                    listParams
                );


        public async Task<IEnumerable<IGroupedSubmissions>> ListCourseGroupedByStudent(long courseId, long assignmentId, ISubmissionIncludes includes = null) =>
            await this.ApiClient.PagableApiOperation<GroupedSubmissions, SubmissionIncludes>(
                    HttpMethod.Get,
                    $"/api/v1/courses/{courseId}/assignments/{assignmentId}/submissions",
                    SubmissionIncludes.Get(includes, true)
                );

        public async Task<IEnumerable<IGroupedSubmissions>> ListCourseGroupedByStudent(long courseId, ISubmissionListParams listParams)
        {
            listParams.Grouped = true;

            return await this.ApiClient.PagableApiOperation<GroupedSubmissions, ISubmissionListParams>(
                        HttpMethod.Get,
                        $"/api/v1/courses/{courseId}/students/submissions",
                        listParams
                    );
        }

        public async Task<IEnumerable<ISubmission>> ListSection(long sectionId, long assignmentId, ISubmissionIncludes includes = null) =>
            await this.ApiClient.PagableApiOperation<Submission, SubmissionIncludes>(
                HttpMethod.Get,
                $"/api/v1/sections/{sectionId}/assignments/{assignmentId}/submissions",
                SubmissionIncludes.Get(includes)
            );

        public async Task<IEnumerable<ISubmission>> ListSection(long sectionId, ISubmissionListParams listParams) =>
            await this.ApiClient.PagableApiOperation<Submission, ISubmissionListParams>(
                HttpMethod.Get,
                $"/api/v1/sections/{sectionId}/students/submissions",
                listParams
            );

        public async Task<IEnumerable<IGroupedSubmissions>> ListSectionGroupedByStudent(long sectionId, long assignmentId, ISubmissionIncludes includes = null) =>
            await this.ApiClient.PagableApiOperation<GroupedSubmissions, SubmissionIncludes>(
                HttpMethod.Get,
                $"/api/v1/sections/{sectionId}/assignments/{assignmentId}/submissions",
                SubmissionIncludes.Get(includes, true)
            );

        public async Task<IEnumerable<IGroupedSubmissions>> ListSectionGroupedByStudent(long sectionId, ISubmissionListParams listParams) {

            listParams.Grouped = true;

            return await this.ApiClient.PagableApiOperation<GroupedSubmissions, ISubmissionListParams>(
                HttpMethod.Get,
                $"/api/v1/sections/{sectionId}/students/submissions",
                listParams
            );
        }

        public async Task<ISubmission> SubmitCourse(long courseId, long assignmentId, ISubmissionSubmit submission) =>
            await this.ApiClient.ApiOperation<Submission, ISubmissionSubmit>(
                HttpMethod.Post,
                $"/api/v1/courses/{courseId}/assignments/{assignmentId}/submissions",
                submission
            );

        public async Task<ISubmission> SubmitSection(long sectionId, long assignmentId, ISubmissionSubmit submission) =>
            await this.ApiClient.ApiOperation<Submission, ISubmissionSubmit>(
                HttpMethod.Post,
                $"/api/v1/sections/{sectionId}/assignments/{assignmentId}/submissions",
                submission
            );

        }
    }
