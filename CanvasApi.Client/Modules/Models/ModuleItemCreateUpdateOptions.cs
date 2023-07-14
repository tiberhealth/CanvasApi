using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class ModuleItemCreateUpdateOptions : IModuleItemCreateUpdateOptions
    {
        IModuleItemDetail IModuleItemCreateUpdateOptions.ModuleItem => ModuleItem;

        internal IModuleItemDetail ModuleItem { get; init; }
    }
}
