using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CanvasApi.Client.Submissions.Enums;
using Newtonsoft.Json;

namespace CanvasApi.Client.Submissions.Models.Concretes
{
    internal class SubmissionIncludes: ISubmissionIncludes
    {
        public SubmissionIncludes() { }

        public IEnumerable<SubmissionListInclude> Includes { get; set; }
        public bool? Grouped { get; set;  }
    }
}
