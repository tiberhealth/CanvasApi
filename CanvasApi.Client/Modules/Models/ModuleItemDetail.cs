using CanvasApi.Client.Modules.Enums;

namespace CanvasApi.Client.Modules.Models
{
    internal class ModuleItemDetail : IModuleItemDetail
    {
        public string Title { get; set; }
        public long? ModuleId { get; set; }
        public bool? Published { get; set; }
        public ModuleItemTypes? Type { get; set; }
        public long? ContentId { get; set; }
        public int? Position { get; set; }
        public int? Indent { get; set; }
        public string PageUrl { get; set; }
        public string ExternalUrl { get; set; }
        public bool? NewTab { get; set; }

        ICompletionRequirement IModuleItemDetail.CompletionRequirement => CompletionRequirement;
        internal CompletionRequirement CompletionRequirement { get; set; }

    }
}
