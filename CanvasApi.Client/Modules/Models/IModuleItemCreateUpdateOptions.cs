using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItemCreateUpdateOptions
    {
        IModuleItemDetail ModuleItem { get; }
    }
}
