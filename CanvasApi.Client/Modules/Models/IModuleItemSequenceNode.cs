namespace CanvasApi.Client.Modules.Models;

public interface IModuleItemSequenceNode
{
    /// <summary>
    /// The previous ModuleItem in the sequence
    /// </summary>
    IModuleItem Prev { get; }
    /// <summary>
    /// The ModuleItem being queried
    /// </summary>
    IModuleItem Current { get; }
    /// <summary>
    /// The next ModuleItem in the sequence
    /// </summary>
    IModuleItem Next { get; }
    /// <summary>
    /// The conditional release rule for the module item, if applicable
    /// </summary>
    IMasteryPath MasteryPath { get; }
}