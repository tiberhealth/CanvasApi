using System.Collections.Generic;
using CanvasApi.Client.Submissions.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Models
{
    public interface ISubmissionIncludes
    {
        IEnumerable<SubmissionListInclude> Includes { get; set; }
        bool? Grouped { get; }
    }
}
