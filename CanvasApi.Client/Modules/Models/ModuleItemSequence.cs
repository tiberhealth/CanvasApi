using System.Collections.Generic;

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
