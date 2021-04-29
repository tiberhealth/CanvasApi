using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItem
    {
        /// <summary>
        /// the unique identifier for the module item
        /// </summary>
        [Multipart("id")] long? Id { get; }
        /// <summary>
        /// the id of the Module this item appears in
        /// </summary>
        [Multipart("module_id")] long? ModuleId { get; }
        /// <summary>
        /// the position of this item in the module (1-based)
        /// </summary>
        [Multipart("position")] int? Position { get; }
        /// <summary>
        /// the title of this item
        /// </summary>
        [Multipart("title")] string Title { get; }
        /// <summary>
        /// 0-based indent level; module items may be indented to show a hierarchy
        /// </summary>
        [Multipart("indent")] int? Indent { get; }
        /// <summary>
        /// the type of object referred to one of 'File', 'Page', 'Discussion',
        /// 'Assignment', 'Quiz', 'SubHeader', 'ExternalUrl', 'ExternalTool'
        /// </summary>
        [Multipart("type")] IEnumerable<ModuleItemTypes> Type { get; }
        /// <summary>
        /// the id of the object referred to applies to 'File', 'Discussion',
        /// 'Assignment', 'Quiz', 'ExternalTool' types
        /// </summary>
        [Multipart("content_id")] long? ContentId { get; }
        /// <summary>
        /// link to the item in Canvas
        /// </summary>
        [Multipart("html_url")] string HtmlUrl { get; }
        /// <summary>
        /// (Optional) link to the Canvas API object, if applicable
        /// </summary>
        [Multipart("url")] string Url { get; }
        /// <summary>
        /// (only for 'Page' type) unique locator for the linked wiki page
        /// </summary>
        [Multipart("page_url")] string PageUrl { get; }
        /// <summary>
        /// (only for 'Page' type) unique locator for the linked wiki page
        /// points to
        /// </summary>
        [Multipart("external_url")] string ExternalUrl { get; }
        /// <summary>
        /// (only for 'ExternalTool' type) whether the external tool opens in a new tab
        /// </summary>
        [Multipart("new_tab")] bool? NewTab { get; }
        /// <summary>
        /// Completion requirement for this module item
        /// </summary>
        [Multipart("completion_requirement")] ICompletionRequirement CompletionRequirement { get; }
        /// <summary>
        /// (Present only if requested through include[]=content_details) If applicable,
        /// returns additional details specific to the associated object
        /// </summary>
        [Multipart("content_details")] IContentDetails ContentDetails { get; }
        /// <summary>
        /// (Optional) Whether this module item is published. This field is present only
        /// if the caller has permission to view unpublished items.
        /// </summary>
        [Multipart("published")] bool? Published { get; }
    }
}