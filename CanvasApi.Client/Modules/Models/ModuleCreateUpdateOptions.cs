using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class ModuleCreateUpdateOptions : IModuleCreateUpdateOptions
    {
        IModuleDetail IModuleCreateUpdateOptions.Module => Module;

        internal IModuleDetail Module { get; init; }
    }
}
