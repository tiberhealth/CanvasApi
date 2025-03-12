﻿namespace CanvasApi.Client.Courses.Models;

internal class ListOptions : ListOptionsBasic, IListOptions
{
    public EnrollmentTypes? EnrollmentType { get; set; }
    public string EnrollmentRole { get; set; }
    public long? EnrollmentRoleId { get; set; }
    public bool? ExcludeBlueprintCourses { get; set; }
}