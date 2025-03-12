namespace CanvasApi.Client.Modules.Models;

internal class ModuleItemShowOptions : IModuleItemShowOptions
{
    public IEnumerable<ModuleItemInclude> Include { get; set; }
    public long? StudentId { get; set; }
}