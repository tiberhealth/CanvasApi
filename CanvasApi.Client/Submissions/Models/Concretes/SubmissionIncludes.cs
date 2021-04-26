using System.Collections.Generic;
using CanvasApi.Client.Submissions.Enums;

namespace CanvasApi.Client.Submissions.Models.Concretes
{
    internal class SubmissionIncludes: ISubmissionIncludes
    {
        public SubmissionIncludes() { }

        public IEnumerable<SubmissionListInclude> Includes { get; set; }
        public bool? Grouped { get; set;  }
    }
}
