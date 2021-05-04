using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Models
{
    public interface IQuizPermissions
    {
        [Multipart("read")] bool? Read { get; }
        [Multipart("submit")] bool? Submit { get; }
        [Multipart("create")] bool? Create { get; }
        [Multipart("manage")] bool? Manage { get; }
        [Multipart("read_statistics")] bool? ReadStatistics { get; }
        [Multipart("review_grades")] bool? ReviewGrades { get; }
        [Multipart("update")] bool? Update { get; }
    }
}
