using CanvasApi.Client.Modules.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class ModuleItemListOptions : IModuleItemListOptions
    {
        public IEnumerable<ModuleItemInclude> Include { get; set; }
        public string SearchTerm { get; set; }
        public long? StudentId { get; set; }
    }
}
