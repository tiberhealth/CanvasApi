using CanvasApi.Client.Modules.Enums;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItemDetail
    {
        /// <summary>
        /// The id of the content to link to the module item. Required, except for 'ExternalUrl', 'Page', and 'SubHeader' types.
        /// </summary>
        long? ContentId { get; set; }
        /// <summary>
        /// External url that the item points to. [Required for 'ExternalUrl' and 'ExternalTool' types.
        /// </summary>
        string ExternalUrl { get; set; }
        /// <summary>
        /// 0-based indent level; module items may be indented to show a hierarchy
        /// </summary>
        int? Indent { get; set; }
        /// <summary>
        /// Whether the external tool opens in a new tab. Only applies to 'ExternalTool' type.
        /// </summary>
        bool? NewTab { get; set; }
        /// <summary>
        /// Suffix for the linked wiki page (e.g. 'front-page'). Required for 'Page' type.
        /// </summary>
        string PageUrl { get; set; }
        /// <summary>
        /// The position of this item in the module (1-based).
        /// </summary>
        int? Position { get; set; }
        /// <summary>
        /// The name of the module item and associated content
        /// </summary>
        string Title { get; set; }
        /// <summary>
        /// The type of content linked to the item
        /// 
        /// Allowed values: <see cref="ModuleItemTypes"/>
        /// </summary>
        ModuleItemTypes? Type { get; set; }
        /// <summary>
        /// The name of the module item and associated content
        /// </summary>
        bool? Published { get; set; }
        /// <summary>
        /// The name of the module item and associated content
        /// </summary>
        long? ModuleId { get; set; }

        /// <summary>
        /// Completion requirement for this module item.
        /// </summary>
        ICompletionRequirement CompletionRequirement { get; }

    }
}