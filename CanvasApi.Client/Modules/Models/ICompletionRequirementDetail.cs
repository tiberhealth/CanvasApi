using CanvasApi.Client.Modules.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface ICompletionRequirementDetail
    {
        [Multipart("type")] IEnumerable<CompletionRequirementTypes> Type { get; set; }
        [Multipart("min_score")] int? MinScore { get; set; }
    }
}