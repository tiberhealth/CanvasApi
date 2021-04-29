using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItemCreateUpdateOptions : IModuleItemCreateUpdateOptions
    {
        IModuleItemDetail IModuleItemCreateUpdateOptions.ModuleItem => this.ModuleItem;

        internal IModuleItemDetail ModuleItem { get; init; }
    }
}
