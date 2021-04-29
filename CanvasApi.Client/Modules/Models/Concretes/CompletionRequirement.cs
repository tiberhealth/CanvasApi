using CanvasApi.Client.Modules.Enums;
using System.Collections.Generic;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class CompletionRequirement : ICompletionRequirement
    {
        public IEnumerable<CompletionRequirementTypes> Type { get; set; }
        public int? MinScore { get; set; }
        public bool? Completed { get; set; }
    }
}
