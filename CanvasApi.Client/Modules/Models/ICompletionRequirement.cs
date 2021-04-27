using CanvasApi.Client.Modules.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface ICompletionRequirement
    {
        [Multipart("completed")] public bool? Completed { get; set; }
        [Multipart("min_score")] public int? MinScore { get; set; }
        [Multipart("type")] public IEnumerable<CompletionRequirementTypes> Type { get; set; }
    }
}