namespace CanvasApi.Client.Modules.Models;

public interface IModuleItemListOptions
{
    /// <summary>
    /// If included, will return additional details specific to the content associated with each item. Refer to the Module Item specification for more details. Includes standard lock information for each item.
    /// 
    /// Allowed values: <see cref="ModuleItemInclude"/>
    /// </summary>
    IEnumerable<ModuleItemInclude> Include { get; set; }
    /// <summary>
    /// The partial title of the items to match and return.
    /// </summary>
    string SearchTerm { get; set; }
    /// <summary>
    /// Returns module completion information for the student with this id.
    /// </summary>
    long? StudentId { get; set; }
}