using CanvasApi.Client.AssignmentGroups.Models;
using CanvasApi.Client.Enrollments.Models;
using CanvasApi.Client.OAuth2.Models;
using CanvasApi.Client.Submissions.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CanvasApi.Client
{
    public static class CanvasApiServiceBinder
    {
        public static void AddTiberCanvasApi(this IServiceCollection services)
        {
            // Authentication
            services.TryAddTransient<IAuthCodeToken, AuthorizationCodeRequest>();
            services.TryAddTransient<IAuthRefreshToken, RefreshTokenRequest>();
            services.TryAddTransient<IAuthClientCredentials, ClientCredentialsRequest>();

            // Enrollments
            services.TryAddTransient<IEnrollmentRequest, EnrollmentRequest>();

            // Assignment Groups
            services.TryAddTransient<IAssignmentGroupGetOptions, AssignmentGroupGetOptions>();
            services.TryAddTransient<IAssignmentGroupListOptions, AssignmentGroupListOptions>();
            services.TryAddTransient<IAssignmentGroupNewEdit, AssignmentGroupNewEdit>();
            services.TryAddTransient<IDeleteAssignmentGroup, DeleteAssignmentGroup>();

            // Submissions
            services.AddTransient<ISubmissionSubmit, SubmissionSubmit>();
            services.AddTransient<ISubmissionSubmitComment, SubmissionSubmitComment>();
            services.AddTransient<ISubmissionSubmitDetail, SubmissionSubmitDetail>();
            services.AddTransient<ISubmissionListParams, SubmissionListParams>();
            services.AddTransient<ISubmissionIncludes, SubmissionIncludes>();


        }
    }
}
