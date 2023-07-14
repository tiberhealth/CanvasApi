using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    internal class ModuleItemSequence : IModuleItemSequence
    {
        public IEnumerable<ModuleItemSequenceNode> Items { get; set; }
        IEnumerable<IModuleItemSequenceNode> IModuleItemSequence.Items => Items;
        public IEnumerable<Module> Modules { get; set; }
        IEnumerable<IModule> IModuleItemSequence.Modules => Modules;
    }
}
