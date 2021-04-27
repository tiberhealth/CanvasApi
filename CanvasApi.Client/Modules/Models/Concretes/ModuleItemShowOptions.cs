using CanvasApi.Client.Modules.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItemShowOptions : IModuleItemShowOptions
    {
        public IEnumerable<ModuleItemInclude> Include { get; set; }
        public long? StudentId { get; set; }
    }
}
