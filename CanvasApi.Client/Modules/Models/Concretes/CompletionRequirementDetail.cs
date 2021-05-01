using CanvasApi.Client.Modules.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class CompletionRequirementDetail : ICompletionRequirementDetail
    {
        public int? MinScore { get; set; }
        public CompletionRequirementTypes Type { get; set; }
    }
}
