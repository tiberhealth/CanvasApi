using CanvasApi.Client.Modules.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItemDetail
    {
        [Multipart("completion_requirement")] ICompletionRequirement CompletionRequirement { get; }
        /// <summary>
        /// The id of the content to link to the module item. Required, except for 'ExternalUrl', 'Page', and 'SubHeader' types.
        /// </summary>
        [Multipart("content_id")] long? ContentId { get; set; }
        /// <summary>
        /// External url that the item points to. [Required for 'ExternalUrl' and 'ExternalTool' types.
        /// </summary>
        [Multipart("external_url")] string ExternalUrl { get; set; }
        /// <summary>
        /// 0-based indent level; module items may be indented to show a hierarchy
        /// </summary>
        [Multipart("indent")] int? Indent { get; set; }
        /// <summary>
        /// Whether the external tool opens in a new tab. Only applies to 'ExternalTool' type.
        /// </summary>
        [Multipart("new_tab")] bool? NewTab { get; set; }
        /// <summary>
        /// Suffix for the linked wiki page (e.g. 'front-page'). Required for 'Page' type.
        /// </summary>
        [Multipart("page_url")] string PageUrl { get; set; }
        /// <summary>
        /// The position of this item in the module (1-based).
        /// </summary>
        [Multipart("position")] int? Position { get; set; }
        /// <summary>
        /// The name of the module item and associated content
        /// </summary>
        [Multipart("title")] string Title { get; set; }
        /// <summary>
        /// The type of content linked to the item
        /// 
        /// Allowed values: <see cref="ModuleItemTypes"/>
        /// </summary>
        [Multipart("type")] ModuleItemTypes? Type { get; set; }
        /// <summary>
        /// The name of the module item and associated content
        /// </summary>
        [Multipart("published")] bool? Published { get; set; }
        /// <summary>
        /// The name of the module item and associated content
        /// </summary>
        [Multipart("module_id")] long? ModuleId { get; set; }
    }
}