using System;
using System.Collections.Generic;
using CanvasApi.Client.Courses.Enums;
using CanvasApi.Client.Enrollments.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Models
{
    public interface IListOptions: IListOptionsBasic
    {
        [JsonProperty("enrollment_type"), EnumAsString] EnrollmentTypes? EnrollmentType { get; set; }
        [Obsolete("Deprecated"), JsonProperty("enrollment_role")] string EnrollmentRole { get; set; }
        [JsonProperty("enrollment_role_id")] long? EnrollmentRoleId { get; set; }
        [JsonProperty("exclude_blueprint_courses")] bool? ExcludeBlueprintCourses { get; set; }
    }
}
