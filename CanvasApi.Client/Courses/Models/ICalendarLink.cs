namespace CanvasApi.Client.Courses.Models;

public interface ICalendarLink
{
    /// <summary>
    /// The URL of the calendar in ICS format
    /// </summary>
    string Ics { get; }
}