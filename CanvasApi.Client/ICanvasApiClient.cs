using CanvasApi.Client.Accounts;
using CanvasApi.Client.Admins;
using CanvasApi.Client.AssignmentGroups;
using CanvasApi.Client.Assignments;
using CanvasApi.Client.Enrollments;
using CanvasApi.Client.EnrollmentTerms;
using CanvasApi.Client.Modules;
using CanvasApi.Client.OAuth2;
using CanvasApi.Client.Pages;
using CanvasApi.Client.Roles;
using CanvasApi.Client.Section;
using CanvasApi.Client.Submissions;
using CanvasApi.Client.Users;

namespace CanvasApi.Client
{
    public interface ICanvasApiClient
    {
        PagingOptions DefaultPagingOptions { get; }

        /// <summary>
        /// API Calls for the Accounts subsystem in Canvas
        /// </summary>
        IAccountsApi Accounts { get; }

        /// <summary>
        /// API Calls for the Admins subsystem in Canvas
        /// </summary>
        IAdminApiClient Admin { get; }

        /// <summary>
        /// API Calls for the Assignment Groups Sub System
        /// </summary>
        IAssignmentGroupsApiClient AssignmentGroups { get; }

        /// <summary>
        /// API Calls for the Assignments Sub System
        /// </summary>
        IAssignmentApiClient Assignments { get; }

        /// <summary>
        /// API Calls for the Enrollments subsystem in Canvas
        /// </summary>
        IEnrollmentApiClient Enrollments { get; }

        /// <summary>
        /// API Calls for the Enrollment terms subsystem in Canvas
        /// </summary>
        IEnrollmentTermsApiClient EnrollmentTerms { get; }

        /// <summary>
        /// API Calls for the Enrollment terms subsystem in Canvas
        /// </summary>
        IModulesApiClient Modules { get; }

        /// <summary>
        /// A{I Calls for Course Sections in Canvas
        /// </summary>
        ISectionApi Sections { get; }

        /// <summary>
        /// API Calls for the Submissions subsystem in Canvas
        /// </summary>
        ISubmissionsApiClient Submissions { get; }

        /// <summary>
        /// API Calls for the Pages subsystem in Canvas
        /// </summary>
        IPageApiClient Pages { get; }

        /// <summary>
        /// API Calls for the Roles subsystem in Canvas
        /// </summary>
        IRolesApiClient Roles { get; }

        /// <summary>
        /// API Calls for the Users Sub System
        /// </summary>
        IUsersApi Users { get; }

        /// <summary>
        /// API Calls for OAuth Authentication in Canvas
        /// </summary>
        IOAuth2Api OAuth2 { get; }

        /// <summary>
        /// Validates the CanvasApi Client configuration
        /// </summary>
        /// <returns>Boolean indicating if the validation was successful or not</returns>
        bool VerifyConfiguration();

    }
}
