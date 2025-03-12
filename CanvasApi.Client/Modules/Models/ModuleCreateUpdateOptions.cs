namespace CanvasApi.Client.Modules.Models;

internal class ModuleCreateUpdateOptions : IModuleCreateUpdateOptions
{
    IModuleDetail IModuleCreateUpdateOptions.Module => Module;

    internal IModuleDetail Module { get; init; }
}