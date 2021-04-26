using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItemSequence
    {
        [JsonProperty("items")] public IEnumerable<IModuleItemSequenceNode> Items { get; set; }
        [JsonProperty("modules")] public IEnumerable<IModule> Modules { get; set; }
    }
}
