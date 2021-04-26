using Newtonsoft.Json;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IModuleItemSequenceNode
    {
        [JsonProperty("current")] IModuleItem Current { get; set; }
        [JsonProperty("mastery_path")] IMasteryPath MasteryPath { get; set; }
        [JsonProperty("next")] IModuleItem Next { get; set; }
        [JsonProperty("prev")] IModuleItem Prev { get; set; }
    }
}