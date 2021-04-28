using Newtonsoft.Json;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IModuleItemSequenceNode
    {
        /// <summary>
        /// The previous ModuleItem in the sequence
        /// </summary>
        [Multipart("prev")] IModuleItem Prev { get; }
        /// <summary>
        /// The ModuleItem being queried
        /// </summary>
        [Multipart("current")] IModuleItem Current { get; }
        /// <summary>
        /// The next ModuleItem in the sequence
        /// </summary>
        [Multipart("next")] IModuleItem Next { get; }
        /// <summary>
        /// The conditional release rule for the module item, if applicable
        /// </summary>
        [Multipart("mastery_path")] IMasteryPath MasteryPath { get; }
    }
}