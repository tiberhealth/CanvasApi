using System;

namespace CanvasApi.Client.Section.Models;

internal class CourseSection : ICourseSection
{
    /// <summary>
    /// The unique identifier for the section.
    /// </summary>
    public long Id { get; set; }
    /// <summary>
    /// The name of the section.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The sis id of the section. This field is only included if the user has
    /// permission to view SIS information.
    /// </summary>
    public string SisSectionId { get; set; }
    /// <summary>
    /// Optional: The integration ID of the section. This field is only included if
    /// the user has permission to view SIS information.
    /// </summary>
    public string IntegrationId { get; set; }
    /// <summary>
    /// The unique identifier for the SIS import if created through SIS. This field
    /// is only included if the user has permission to manage SIS information.
    /// </summary>
    public long? SisImportId { get; set; }
    /// <summary>
    /// The unique Canvas identifier for the course in which the section belongs
    /// </summary>
    public long? CourseId { get; set; }
    /// <summary>
    /// The unique SIS identifier for the course in which the section belongs. This
    /// field is only included if the user has permission to view SIS information.
    /// </summary>
    public string SessionCourseId { get; set; }
    /// <summary>
    /// the start date for the section, if applicable
    /// </summary>
    public DateTime? StartAt { get; set; }
    /// <summary>
    /// the end date for the section, if applicable
    /// </summary>
    public DateTime? EndAt { get; set; }
    /// <summary>
    /// Restrict user enrollments to the start and end dates of the section
    /// </summary>
    public bool? RestrictuserEnrollmentsToSectionDate { get; set; }
    /// <summary>
    /// The unique identifier of the original course of a cross-listed section
    /// </summary>
    public long? NonxlistCourseId { get; set; }
    /// <summary>
    /// optional: the total number of active and invited students in the section
    /// </summary>
    public long? TotalStudents { get; set; }
}
