using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItemSequence
    {
        [Multipart("items")] public IEnumerable<IModuleItemSequenceNode> Items { get; set; }
        [Multipart("modules")] public IEnumerable<IModule> Modules { get; set; }
    }
}
