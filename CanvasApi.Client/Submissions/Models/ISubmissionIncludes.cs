using System.Collections.Generic;
using CanvasApi.Client.Submissions.Enums;

namespace CanvasApi.Client.Submissions.Models
{
    public interface ISubmissionIncludes
    {
        IEnumerable<SubmissionListInclude> Includes { get; set; }
        bool? Grouped { get; }
    }
}
