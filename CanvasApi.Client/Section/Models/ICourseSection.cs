using System;

namespace CanvasApi.Client.Section.Models;

public interface ICourseSection
{
    /// <summary>
    /// The unique identifier for the section.
    /// </summary>
    long Id { get; }
    /// <summary>
    /// The name of the section.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// The sis id of the section. This field is only included if the user has
    /// permission to view SIS information.
    /// </summary>
    string SisSectionId { get; }
    /// <summary>
    /// Optional: The integration ID of the section. This field is only included if
    /// the user has permission to view SIS information.
    /// </summary>
    string IntegrationId { get; }
    /// <summary>
    /// The unique identifier for the SIS import if created through SIS. This field
    /// is only included if the user has permission to manage SIS information.
    /// </summary>
    long? SisImportId { get; }
    /// <summary>
    /// The unique Canvas identifier for the course in which the section belongs
    /// </summary>
    long? CourseId { get; }
    /// <summary>
    /// The unique SIS identifier for the course in which the section belongs. This
    /// field is only included if the user has permission to view SIS information.
    /// </summary>
    string SessionCourseId { get; }
    /// <summary>
    /// the start date for the section, if applicable
    /// </summary>
    DateTime? StartAt { get; }
    /// <summary>
    /// the end date for the section, if applicable
    /// </summary>
    DateTime? EndAt { get; }
    /// <summary>
    /// Restrict user enrollments to the start and end dates of the section
    /// </summary>
    bool? RestrictuserEnrollmentsToSectionDate { get; }
    /// <summary>
    /// The unique identifier of the original course of a cross-listed section
    /// </summary>
    long? NonxlistCourseId { get; }
    /// <summary>
    /// optional: the total number of active and invited students in the section
    /// </summary>
    long? TotalStudents { get; }
}
