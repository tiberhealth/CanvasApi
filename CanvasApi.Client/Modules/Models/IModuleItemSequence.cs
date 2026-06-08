namespace CanvasApi.Client.Modules.Models;

public interface IModuleItemSequence
{
    /// <summary>
    /// an array containing one ModuleItemSequenceNode for each appearence of the
    /// asset in the module sequence (up to 10 total)
    /// </summary>
    IEnumerable<IModuleItemSequenceNode> Items { get; }
    /// <summary>
    /// an array containing each Module referenced above
    /// </summary>
    IEnumerable<IModule> Modules { get; }
}