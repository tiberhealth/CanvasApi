using System.Collections.Generic;
using CanvasApi.Client.Courses.Enums;
using CanvasApi.Client.Enrollments.Enums;

namespace CanvasApi.Client.Courses.Models.Concrete
{
    internal class ListOptionsBasic : IListOptionsBasic
    {
        public IEnumerable<CourseIncludes> Includes { get; set; }
        public EnrollmentState? EnrollmentState { get; set; }
        public IEnumerable<CourseState> State { get; set; }
    }
}
