using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleCreateUpdateOptions : IModuleCreateUpdateOptions
    {
        IModuleDetail IModuleCreateUpdateOptions.Module => this.Module;

        internal IModuleDetail Module { get; init; }
    }
}
