namespace CanvasApi.Client.Modules.Models;

internal class ModuleShowOptions : IModuleShowOptions
{
    public IEnumerable<ModuleInclude> Include { get; set; }
    public long? StudentId { get; set; }
}