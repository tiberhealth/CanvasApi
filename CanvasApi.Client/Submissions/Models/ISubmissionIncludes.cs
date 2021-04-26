using System.Collections.Generic;
using CanvasApi.Client.Submissions.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Models
{
    public interface ISubmissionIncludes
    {
        [Multipart("include")] IEnumerable<SubmissionListInclude> Includes { get; set; }
        [Multipart("grouped")] bool? Grouped { get; }
    }
}
