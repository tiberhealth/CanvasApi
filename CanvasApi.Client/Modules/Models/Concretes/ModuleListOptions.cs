using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleListOptions
    {
        public IEnumerable<ModuleInclude> Include { get; set; }
        public string SearchTerm { get; set; }
        public string StudentId { get; set; }
    }
}
