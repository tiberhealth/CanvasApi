using CanvasApi.Client.Modules.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItemDetail : IModuleItemDetail
    {
        public string Title { get; set; }
        public IEnumerable<ModuleItemTypes> Type { get; set; }
        public long? ContentId { get; set; }
        public int? Position { get; set; }
        public int? Indent { get; set; }
        public string PageUrl { get; set; }
        public string ExternalUrl { get; set; }
        public bool? NewTab { get; set; }
        public CompletionRequirementDetail CompletionRequirement { get; set; }

        ICompletionRequirementDetail IModuleItemDetail.CompletionRequirement => this.CompletionRequirement;
    }
}
