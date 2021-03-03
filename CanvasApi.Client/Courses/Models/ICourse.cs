using System;
using System.Collections.Generic;
using CanvasApi.Client.Enrollments.Models;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.Courses.Models
{
    public interface ICourse
    {
        /// <summary>
        /// the unique identifier for the course
        /// </summary>
        long Id { get; }

        /// <summary>
        /// the SIS identifier for the course, if defined. This field is only included if
        /// the user has permission to view SIS information.
        /// </summary>
        string SisCourseId { get; }

        /// <summary>
        /// the UUID of the course
        /// </summary>
        string Uuid { get; }

        /// <summary>
        /// the integration identifier for the course, if defined. This field is only
        /// included if the user has permission to view SIS information.
        /// </summary>
        string IntegrationId { get; }

        /// <summary>
        /// the unique identifier for the SIS import. This field is only included if the
        /// user has permission to manage SIS information.
        /// </summary>
        long? SisImportId { get; }

        /// <summary>
        /// the full name of the course
        /// </summary>
        string Name { get; }

        /// <summary>
        /// the course code
        /// </summary>
        string CourseCode { get; }

        /// <summary>
        /// the current state of the course one of 'unpublished', 'available',
        /// 'completed', or 'deleted'
        /// </summary>
        string WorkflowState { get; }

        /// <summary>
        /// the account associated with the course
        /// </summary>
        long? AccountId { get; }

        /// <summary>
        /// the root account associated with the course
        /// </summary>
        long? RootAccountId { get; }

        /// <summary>
        /// the enrollment term associated with the course
        /// </summary>
        long? EnrollmentTermId { get; }

        /// <summary>
        /// the grading standard associated with the course
        /// </summary>
        long? GradingStandardId { get; }

        /// <summary>
        /// the grade_passback_setting set on the course
        /// </summary>
        string GradePassbackSetting { get; }

        /// <summary>
        /// the date the course was created.
        /// </summary>
        DateTime? CreatedAt { get; }

        /// <summary>
        /// the start date for the course, if applicable
        /// </summary>
        DateTime? StartAt { get; }

        /// <summary>
        /// the end date for the course, if applicable
        /// </summary>
        DateTime? EndAt { get; }

        /// <summary>
        /// the course-set locale, if applicable
        /// </summary>
        string Locale { get; }

        /// <summary>
        /// A list of enrollments linking the current user to the course. for student
        /// enrollments, grading information may be included if include[]=total_scores
        /// </summary>
        IEnumerable<IEnrollment> Enrollments { get; }

        /// <summary>
        /// optional: the total number of active and invited students in the course
        /// </summary>
        int? TotalStudents { get; }

        /// <summary>
        /// course calendar
        /// </summary>
        ICalendarLink Calendar { get; }

        /// <summary>
        /// the type of page that users will see when they first visit the course -
        /// 'feed': Recent Activity Dashboard - 'wiki': Wiki Front Page - 'modules':
        /// Course Modules/Sections Page - 'assignments': Course Assignments List -
        /// 'syllabus': Course Syllabus Page other types may be added in the future
        /// </summary>
        string DefaultView { get; }

        /// <summary>
        /// optional: user-generated HTML for the course syllabus
        /// </summary>
        string SyllabusBody { get; }

        /// <summary>
        /// optional: the number of submissions needing grading returned only if the
        /// current user has grading rights and include[]=needs_grading_count
        /// </summary>
        int? NeedsGradingCount { get; }

        /// <summary>
        /// optional: the enrollment term object for the course returned only if
        /// include[]=term
        /// </summary>
        ITerm Term { get; }

        /// <summary>
        /// optional: information on progress through the course returned only if
        /// include[]=course_progress
        /// </summary>
        ICourseProgress CourseProgress { get; }

        /// <summary>
        /// weight final grade based on assignment group percentages
        /// </summary>
        bool? ApplyAssignmentGroupWeights { get; }

        /// <summary>
        /// optional: the permissions the user has for the course. returned only for a
        /// single course and include[]=permissions
        /// </summary>
        JObject Permissions { get; }
        bool? IsPublic { get; }
        bool? IsPublicToAuthUsers { get; }
        bool? PublicSyllabus { get; }
        bool? PublicSyllabusToAuth { get; }

        /// <summary>
        /// optional: the public description of the course
        /// </summary>
        string PublicDescription { get; }
        decimal? StorageQuotaMb { get; }
        decimal? StorageQuotaUsedMb { get; }
        bool? HideFinalGrades { get; }
        string License { get; }
        bool? AllowStudentAssignmentEdits { get; }
        bool? AllowWikiComments { get; }
        bool? AllowStudentForumAttachments { get; }
        bool? OpenEnrollment { get; }
        bool? SelfEnrollment { get; }
        bool? RestrictEnrollmentsToCourseDates { get; }
        string CourseFormat { get; }

        /// <summary>
        /// optional: this will be true if this user is currently prevented from viewing
        /// the course because of date restriction settings
        /// </summary>
        bool? AccessRestrictedByDate { get; }

        /// <summary>
        /// The course's IANA time zone name.
        /// </summary>
        string TimeZone { get; }

        /// <summary>
        /// optional: whether the course is set as a Blueprint Course (blueprint fields
        /// require the Blueprint Courses feature)
        /// </summary>
        bool? Blueprint { get; }

        /// <summary>
        /// optional: Set of restrictions applied to all locked course objects
        /// </summary>
        JObject BlueprintRestrictions { get; }

        /// <summary>
        /// optional: Sets of restrictions differentiated by object type applied to
        /// locked course objects
        /// </summary>
        JObject BlueprintRestrictionsByObjectType { get; }
    }
}
