using CanvasApi.Client.Modules.Models.Concretes;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItemSequence
    {
        [Multipart("items")] IEnumerable<IModuleItemSequenceNode> Items { get; set; }
        [Multipart("modules")] IEnumerable<IModule> Modules { get; set; }
    }
}