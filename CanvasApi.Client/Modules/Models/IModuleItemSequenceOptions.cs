namespace CanvasApi.Client.Modules.Models;

public interface IModuleItemSequenceOptions
{
    /// <summary>
    /// The type of asset to find module sequence information for. Use the ModuleItem if it is known(e.g., the user navigated from a module item), since this will avoid ambiguity if the asset appears more than once in the module sequence.
    /// 
    /// Allowed values: <see cref="ModuleItemSequenceAssetTypes"/>
    /// </summary>
    ModuleItemSequenceAssetTypes AssetType { get; set; }
    /// <summary>
    /// The id of the asset (or the url in the case of a Page)
    /// </summary>
    long? AssetId { get; set; }
}