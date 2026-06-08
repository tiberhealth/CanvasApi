namespace CanvasApi.Client.Modules.Models;

internal class ModuleCreateUpdateOptions : IModuleCreateUpdateOptions
{
    IModuleDetail IModuleCreateUpdateOptions.Module => this.Module;

    internal IModuleDetail Module { get; init; }
}