namespace CanvasApi.Client.Modules.Models
{
    internal class ModuleItemCreateUpdateOptions : IModuleItemCreateUpdateOptions
    {
        IModuleItemDetail IModuleItemCreateUpdateOptions.ModuleItem => ModuleItem;

        internal IModuleItemDetail ModuleItem { get; init; }
    }
}
