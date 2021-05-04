using System;
using CanvasApi.Client.Enrollments.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Models
{
    public interface IListOptions: IListOptionsBasic
    {
        [Multipart("enrollment_type"), EnumAsString] EnrollmentTypes? EnrollmentType { get; set; }
        [Obsolete("Deprecated"), Multipart("enrollment_role")] string EnrollmentRole { get; set; }
        long? EnrollmentRoleId { get; set; }
        bool? ExcludeBlueprintCourses { get; set; }
    }
}
