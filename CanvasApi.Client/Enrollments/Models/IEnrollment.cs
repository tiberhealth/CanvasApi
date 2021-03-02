using System;
using CanvasApi.Client.Users.Models;

namespace CanvasApi.Client.Enrollments.Models
{
    public interface IEnrollment
    {
        /// <summary>
        /// The ID of the enrollment.
        long Id { get; }
        /// <summary>
        /// The unique id of the course.
        /// </summary>
        long CourseId { get; }
        /// <summary>
        /// The SIS Course ID in which the enrollment is associated. Only displayed if
        /// present. This field is only included if the user has permission to view SIS
        /// information.
        /// </summary>
        string SisCourseId { get; }
        /// <summary>
        /// The Course Integration ID in which the enrollment is associated. This field
        /// is only included if the user has permission to view SIS information.
        /// </summary>
        string CourseIntegrationId { get; }
        /// <summary>
        /// The unique id of the user's section.
        /// </summary>
        int? CourseSectionId { get; }
        /// <summary>
        /// The Section Integration ID in which the enrollment is associated. This field
        /// is only included if the user has permission to view SIS information.
        /// </summary>
        string SectionIntegrationId { get; }
        /// <summary>
        /// The SIS Account ID in which the enrollment is associated. Only displayed if
        /// present. This field is only included if the user has permission to view SIS
        /// information.
        /// </summary>
        string SisAccountId { get; }
        /// <summary>
        /// The SIS Section ID in which the enrollment is associated. Only displayed if
        /// present. This field is only included if the user has permission to view SIS
        /// information.
        /// </summary>
        string SisSectionId { get; }
        /// <summary>
        /// The SIS User ID in which the enrollment is associated. Only displayed if
        /// present. This field is only included if the user has permission to view SIS
        /// information.
        /// </summary>
        string SisUserId { get; }
        /// <summary>
        /// The state of the user's enrollment in the course.
        /// </summary>
        string EnrollmentState { get; }
        /// <summary>
        /// User can only access his or her own course section.
        /// </summary>
        bool? LimitPrivilegesToCourseSection { get; }
        /// <summary>
        /// The unique identifier for the SIS import. This field is only included if the
        /// user has permission to manage SIS information.
        /// </summary>
        long? SisImportId { get; }
        /// <summary>
        /// The unique id of the user's account.
        /// </summary>
        long? RootAccountId { get; }
        /// <summary>
        /// The enrollment type. One of 'StudentEnrollment', 'TeacherEnrollment',
        /// 'TaEnrollment', 'DesignerEnrollment', 'ObserverEnrollment'.
        /// </summary>
        string Type { get; }
        /// <summary>
        /// The unique id of the user.
        /// </summary>
        long? UserId { get; }
        /// <summary>
        /// The unique id of the associated user. Will be null unless type is
        /// ObserverEnrollment.
        /// </summary>
        string AssociatedUserId { get; }
        /// <summary>
        /// The enrollment role, for course-level permissions. This field will match
        /// `type` if the enrollment role has not been customized.
        /// </summary>
        string Role { get; }
        /// <summary>
        /// The id of the enrollment role.
        /// </summary>
        long? RoleId { get; }
        /// <summary>
        /// The created time of the enrollment, in ISO8601 format.
        /// </summary>
        DateTime? CreatedAt { get; }
        /// <summary>
        /// The updated time of the enrollment, in ISO8601 format.
        /// </summary>
        DateTime? UpdatedAt { get; }
        /// <summary>
        /// The start time of the enrollment, in ISO8601 format.
        /// </summary>
        DateTime? StartAt { get; }
        /// <summary>
        /// The end time of the enrollment, in ISO8601 format.
        /// </summary>
        DateTime? EndAt { get; }
        /// <summary>
        /// The last activity time of the user for the enrollment, in ISO8601 format.
        /// </summary>
        DateTime? LastActivityAt { get; }
        /// <summary>
        /// The last attended date of the user for the enrollment in a course, in ISO8601
        /// format.
        /// </summary>
        DateTime? LastAttendedAt { get; }
        /// <summary>
        /// The total activity time of the user for the enrollment, in seconds.
        /// </summary>
        long? TotalActivityTime { get; }
        /// <summary>
        /// The URL to the Canvas web UI page for this course enrollment.
        string HtmlUrl { get; }
        /// <summary>
        /// The URL to the Canvas web UI page containing the grades associated with this
        /// enrollment.
        /// </summary>
        IGrade Grades { get; }
        /// <summary>
        /// A description of the user.
        /// </summary>
        IUserDisplay User { get; }
        /// <summary>
        /// The user's override grade for the course.
        /// </summary>
        string OverrideGrade { get; }
        /// <summary>
        /// The user's override score for the course.
        /// </summary>
        decimal? OverrideScore { get; }
        /// <summary>
        /// The user's current grade in the class including muted/unposted assignments.
        /// Only included if user has permissions to view this grade, typically teachers,
        /// TAs, and admins.
        /// </summary>
        string UnpostedCurrentGrade { get; }
        /// <summary>
        /// The user's final grade for the class including muted/unposted assignments.
        /// Only included if user has permissions to view this grade, typically teachers,
        /// TAs, and admins..
        /// </summary>
        string UnpostedFinalGrade { get; }
        /// <summary>
        /// The user's current score in the class including muted/unposted assignments.
        /// Only included if user has permissions to view this score, typically teachers,
        /// TAs, and admins..
        /// </summary>
        string UnpostedCurrentScore { get; }
        /// <summary>
        /// The user's final score for the class including muted/unposted assignments.
        /// Only included if user has permissions to view this score, typically teachers,
        /// TAs, and admins..
        /// </summary>
        string UnpostedFinalScore { get; }
        /// <summary>
        /// optional: Indicates whether the course the enrollment belongs to has grading
        /// periods set up. (applies only to student enrollments, and only available in
        /// course endpoints)
        /// </summary>
        bool? HasGradingPeriods { get; }
        /// <summary>
        /// optional: Indicates whether the course the enrollment belongs to has the
        /// Display Totals for 'All Grading Periods' feature enabled. (applies only to
        /// student enrollments, and only available in course endpoints)
        /// </summary>
        bool? TotalsForAllGradingPeriodsOption { get; }
        /// <summary>
        /// optional: The name of the currently active grading period, if one exists. If
        /// the course the enrollment belongs to does not have grading periods, or if no
        /// currently active grading period exists, the value will be null. (applies only
        /// to student enrollments, and only available in course endpoints)
        /// </summary>
        string CurrentGradingPeriodTitle { get; }
        /// <summary>
        /// optional: The id of the currently active grading period, if one exists. If
        /// the course the enrollment belongs to does not have grading periods, or if no
        /// currently active grading period exists, the value will be null. (applies only
        /// to student enrollments, and only available in course endpoints)
        /// </summary>
        long? CurrentGradingPeriodId { get; }
        /// <summary>
        /// The user's override grade for the current grading period.
        /// </summary>
        string CurrentPeriodOverrideGrade { get; }
        /// <summary>
        /// The user's override score for the current grading period.
        /// </summary>
        decimal? CurrentPeriodOverrideScore { get; }
        /// <summary>
        /// optional: The student's score in the course for the current grading period,
        /// including muted/unposted assignments. Only included if user has permission to
        /// view this score, typically teachers, TAs, and admins. If the course the
        /// enrollment belongs to does not have grading periods, or if no currently
        /// active grading period exists, the value will be null. (applies only to
        /// student enrollments, and only available in course endpoints)
        /// </summary>
        decimal? CurrentPeriodUnpostedCurrentScore { get; }
        /// <summary>
        /// optional: The student's score in the course for the current grading period,
        /// including muted/unposted assignments and including ungraded assignments with
        /// a score of 0. Only included if user has permission to view this score,
        /// typically teachers, TAs, and admins. If the course the enrollment belongs to
        /// does not have grading periods, or if no currently active grading period
        /// exists, the value will be null. (applies only to student enrollments, and
        /// only available in course endpoints)
        /// </summary>
        decimal? CurrentPeriodUnpostedFinalScore { get; }
        /// <summary>
        /// optional: The letter grade equivalent of
        /// current_period_unposted_current_score, if available. Only included if user
        /// has permission to view this grade, typically teachers, TAs, and admins. If
        /// the course the enrollment belongs to does not have grading periods, or if no
        /// currently active grading period exists, the value will be null. (applies only
        /// to student enrollments, and only available in course endpoints)
        /// </summary>
        string CurrentPeriodUnpostedCurrentGrade { get; }
        /// <summary>
        /// optional: The letter grade equivalent of current_period_unposted_final_score,
        /// if available. Only included if user has permission to view this grade,
        /// typically teachers, TAs, and admins. If the course the enrollment belongs to
        /// does not have grading periods, or if no currently active grading period
        /// exists, the value will be null. (applies only to student enrollments, and
        /// only available in course endpoints)
        /// </summary>
        string CurrentPeriodUnpostedFinalGrade { get; }
    }
}
