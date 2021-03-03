using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CanvasApi.Client.Submissions.Enums;
using Newtonsoft.Json;

namespace CanvasApi.Client.Submissions.Models
{
    internal class SubmissionIncludes: ISubmissionIncludes
    {
        public SubmissionIncludes() { }

        [JsonProperty("include")] public IEnumerable<SubmissionListInclude> Includes { get; set; }
        [JsonProperty("grouped")] public bool? Grouped { get; private set; }

        internal static SubmissionIncludes Get(ISubmissionIncludes parent, bool? grouped = null) =>
            new SubmissionIncludes()
            {
                Includes = parent.Includes,
                Grouped = grouped
            };

    }
}
