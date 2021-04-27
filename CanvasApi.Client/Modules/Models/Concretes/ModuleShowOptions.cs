using CanvasApi.Client.Modules.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleShowOptions
    {
        public IEnumerable<ModuleInclude> Include { get; set; }
        public string StudentId { get; set; }
    }
}
