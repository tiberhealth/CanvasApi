using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItemSequenceNode : IModuleItemSequenceNode
    {
        [JsonProperty("prev")] public IModuleItem Prev { get; set; }
        [JsonProperty("current")] public IModuleItem Current { get; set; }
        [JsonProperty("next")] public IModuleItem Next { get; set; }
        [JsonProperty("mastery_path")] public IMasteryPath MasteryPath { get; set; }
    }
}
