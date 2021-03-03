using System;
using System.Collections.Generic;
using CanvasApi.Client.Submissions.Enums;
using Newtonsoft.Json;

namespace CanvasApi.Client.Submissions.Models
{
    public interface ISubmissionIncludes
    {
        [JsonProperty("include")] IEnumerable<SubmissionListInclude> Includes { get; set; }
    }
}
