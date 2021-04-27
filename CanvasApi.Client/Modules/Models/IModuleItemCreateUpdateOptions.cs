using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItemCreateUpdateOptions
    {
        [Multipart("module_item")] IModuleItemDetail ModuleItem { get; }
    }
}
