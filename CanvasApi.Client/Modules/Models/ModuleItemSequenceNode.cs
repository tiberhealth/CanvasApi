namespace CanvasApi.Client.Modules.Models
{
    internal class ModuleItemSequenceNode : IModuleItemSequenceNode
    {
        public ModuleItem Prev { get; set; }
        IModuleItem IModuleItemSequenceNode.Prev => Prev;
        public ModuleItem Current { get; set; }
        IModuleItem IModuleItemSequenceNode.Current => Current;
        public ModuleItem Next { get; set; }
        IModuleItem IModuleItemSequenceNode.Next => Next;
        public MasteryPath MasteryPath { get; set; }
        IMasteryPath IModuleItemSequenceNode.MasteryPath => MasteryPath;
    }
}
