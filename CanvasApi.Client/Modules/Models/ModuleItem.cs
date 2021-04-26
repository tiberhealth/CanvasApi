using CanvasApi.Client.Modules.Enums;
using System.Collections.Generic;

namespace CanvasApi.Client.Modules.Models
{
    internal class ModuleItem
    {
        public long Id { get; set; }
        public long ModuleId { get; set; }
        public int Position { get; set; }
        public string Title { get; set; }
        public int Indent { get; set; }
        public IEnumerable<ModuleTypes> Type { get; set; }
        public string HtmlUrl { get; set; }
        public ICompletionRequirement CompletionRequirement { get; set; }
    }
}
