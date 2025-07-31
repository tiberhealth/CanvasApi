namespace CanvasApi.Client.Modules.Models;

internal class ModuleItemCreateUpdateOptions : IModuleItemCreateUpdateOptions
{
    IModuleItemDetail IModuleItemCreateUpdateOptions.ModuleItem => this.ModuleItem;

    internal IModuleItemDetail ModuleItem { get; init; }
}