using CanvasApi.Client.Modules.Models.Concretes;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItemSequence
    {
        /// <summary>
        /// an array containing one ModuleItemSequenceNode for each appearence of the
        /// asset in the module sequence (up to 10 total)
        /// </summary>
        [Multipart("items")] IEnumerable<IModuleItemSequenceNode> Items { get; }
        /// <summary>
        /// an array containing each Module referenced above
        /// </summary>
        [Multipart("modules")] IEnumerable<IModule> Modules { get; }
    }
}