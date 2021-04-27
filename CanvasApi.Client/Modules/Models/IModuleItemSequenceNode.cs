using Newtonsoft.Json;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IModuleItemSequenceNode
    {
        [Multipart("current")] IModuleItem Current { get; set; }
        [Multipart("mastery_path")] IMasteryPath MasteryPath { get; set; }
        [Multipart("next")] IModuleItem Next { get; set; }
        [Multipart("prev")] IModuleItem Prev { get; set; }
    }
}