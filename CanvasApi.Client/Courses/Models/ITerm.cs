using System;
namespace CanvasApi.Client.Courses.Models
{
    public interface ITerm
    {
        long Id { get; }
        string Name { get; }
        DateTime? StartAt { get; }
        DateTime? EndAt { get; }
    }
}
