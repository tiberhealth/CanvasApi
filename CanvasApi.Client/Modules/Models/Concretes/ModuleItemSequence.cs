using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItemSequence : IModuleItemSequence
    {
        public IEnumerable<ModuleItemSequenceNode> Items { get; set; }
        IEnumerable<IModuleItemSequenceNode> IModuleItemSequence.Items => this.Items;
        public IEnumerable<Module> Modules { get; set; }
        IEnumerable<IModule> IModuleItemSequence.Modules => this.Modules;
    }
}
