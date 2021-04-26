using System;
using CanvasApi.Client.Enrollments.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Models
{
    public interface IListOptions: IListOptionsBasic
    {
        [Multipart("enrollment_type"), EnumAsString] EnrollmentTypes? EnrollmentType { get; set; }
        [Obsolete("Deprecated"), Multipart("enrollment_role")] string EnrollmentRole { get; set; }
        [Multipart("enrollment_role_id")] long? EnrollmentRoleId { get; set; }
        [Multipart("exclude_blueprint_courses")] bool? ExcludeBlueprintCourses { get; set; }
    }
}
