using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CanvasApi.Client.Submissions.Models
{
    public interface IGroupedSubmissions
    {
        long UserId { get; }
        IEnumerable<ISubmission> Submissions { get; }
     }
}
