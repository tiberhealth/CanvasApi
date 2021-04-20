using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Enums
{
    public enum CourseIncludes
    {
        /// <summary>
        /// Optional information to include with each Course. When needs_grading_count is given,
        /// and the current user has grading rights, the total number of submissions needing grading
        /// for all assignments is returned.
        /// </summary>
        [EnumSerializedValue("needs_grading_count")] NeedsGradingCount,

        /// <summary>
        /// Optional information to include with each Course. When syllabus_body
        /// is given the user-generated html for the course syllabus is returned
        /// </summary>
        [EnumSerializedValue("syllabus_body")] SyllabusBody,

        /// <summary>
        /// Optional information to include with each Course. When public_description
        /// is given the user-generated text for the course public description is returned.
        /// </summary>
        [EnumSerializedValue("public_description")] PublicDescription,

        /// <summary>
        /// ional information to include with each Course. When total_scores is given,
        /// any student enrollments will also include the fields 'computed_current_score',
        /// 'computed_final_score', 'computed_current_grade', and 'computed_final_grade',
        /// as well as (if the user has permission) 'unposted_current_score', 'unposted_final_score',
        /// 'unposted_current_grade', and 'unposted_final_grade' (see Enrollment documentation for
        /// more information on these fields). This argument is ignored if the course is configured to hide final grades.
        /// </summary>
        [EnumSerializedValue("total_scores")] TotalScores,

        /// <summary>
        /// Optional information to include with each Course. When current_grading_period_scores is
        /// given and total_scores is given, any student enrollments will also include the fields
        /// 'has_grading_periods', 'totals_for_all_grading_periods_option', 'current_grading_period_title',
        /// 'current_grading_period_id', current_period_computed_current_score', 'current_period_computed_final_score',
        /// 'current_period_computed_current_grade', and 'current_period_computed_final_grade',
        /// as well as (if the user has permission) 'current_period_unposted_current_score',
        /// 'current_period_unposted_final_score', 'current_period_unposted_current_grade', and 'current_period_unposted_final_grade'
        /// (see Enrollment documentation for more information on these fields).
        ///
        /// In addition, when this argument is passed, the course will have a
        /// 'has_grading_periods' attribute on it. This argument is ignored if
        /// the total_scores argument is not included. If the course is configured to
        /// hide final grades, the following fields are not returned: 'totals_for_all_grading_periods_option',
        /// 'current_period_computed_current_score', 'current_period_computed_final_score',
        /// 'current_period_computed_current_grade', 'current_period_computed_final_grade',
        /// 'current_period_unposted_current_score', 'current_period_unposted_final_score',
        /// 'current_period_unposted_current_grade', and 'current_period_unposted_final_grade'
        /// </summary>
        [EnumSerializedValue("current_grading_period_scores")] CurrentGradingPeriodScores,

        /// <summary>
        /// Optional information to include with each Course. When term is given, the information
        /// for the enrollment term for each course is returned.
        /// </summary>
        [EnumSerializedValue("term")] Term,

        /// <summary>
        /// Optional information to include with each Course. When account is given, the account json for each course is returned.
        /// </summary>
        [EnumSerializedValue("account")] Account,

        /// <summary>
        /// Optional information to include with each Course. When course_progress is given, each course will include a 'course_progress'
        /// object with the fields: 'requirement_count', an integer specifying the total number of requirements in the course,
        /// 'requirement_completed_count', an integer specifying the total number of requirements in this course that have been
        /// completed, and 'next_requirement_url', a string url to the next requirement item, and 'completed_at', the date the
        /// course was completed (null if incomplete). 'next_requirement_url' will be null if all requirements have been completed
        /// or the current module does not require sequential progress. “course_progress” will return an error message if the course
        /// is not module based or the user is not enrolled as a student in the course
        /// </summary>
        [EnumSerializedValue("course_progress")] CourseProgress,

        /// <summary>
        /// Optional information to include with each Course. When course_progress is given, each course will include
        /// a 'course_progress' object with the fields: 'requirement_count', an integer specifying the total number of
        /// requirements in the course, 'requirement_completed_count', an integer specifying the total number of requirements
        /// in this course that have been completed, and 'next_requirement_url', a string url to the next requirement item,
        /// and 'completed_at', the date the course was completed (null if incomplete). 'next_requirement_url' will be null
        /// if all requirements have been completed or the current module does not require sequential progress.
        /// “course_progress” will return an error message if the course is not module based or the user is not enrolled
        /// as a student in the course
        /// </summary>
        [EnumSerializedValue("sections")] Sections,

        /// <summary>
        /// The amount of storage space used by the files in this course
        /// </summary>
        [EnumSerializedValue("storage_quota_used_mb")] StorageQuotaUsedMb,

        /// <summary>
        /// Optional information to include with each Course. Returns an integer for the total amount of active and invited students.
        /// </summary>
        [EnumSerializedValue("total_students")] TotalStudents,

        /// <summary>
        /// Include the grade passback_status
        /// </summary>
        [EnumSerializedValue("passback_status")] PassbackStatus,

        /// <summary>
        /// ional information to include with each Course. Indicates if the user has marked the course as a favorite course.
        /// </summary>
        [EnumSerializedValue("favorites")] Favorites,

        /// <summary>
        /// Teacher information to include with each Course. Returns an array of hashes containing the UserDisplay information for each teacher in the course.
        /// </summary>
        [EnumSerializedValue("teachers")] Teachers,

        /// <summary>
        /// Optional information to include with each Course. Will include data for observed users if the current user has an observer enrollment.
        /// </summary>
        [EnumSerializedValue("observed_users")] ObservedUsers,

        /// <summary>
        /// Optional course image data for when there is a course image and the course image feature flag has been enabled
        /// </summary>
        [EnumSerializedValue("course_image")] CourseImage,

        /// <summary>
        /// Optional information to include with each Course. Indicates whether the course has been concluded, taking course and term dates into account
        /// </summary>
        [EnumSerializedValue("concluded")] Concluded
    }
}
