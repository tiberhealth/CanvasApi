namespace CanvasApi.Client.Courses.Models;

internal class ListOptionsBasic : IListOptionsBasic
{
    public IEnumerable<CourseIncludes> Includes { get; set; }
    public EnrollmentState? EnrollmentState { get; set; }
    public IEnumerable<CourseState> State { get; set; }
}