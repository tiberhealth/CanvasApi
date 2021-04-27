using CanvasApi.Client.Modules.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItemDetail
    {
        [Multipart("completion_requirement")] ICompletionRequirementDetail CompletionRequirement { get; }
        [Multipart("content_id")] long? ContentId { get; set; }
        [Multipart("external_url")] string ExternalUrl { get; set; }
        [Multipart("indent")] int? Indent { get; set; }
        [Multipart("new_tab")] bool? NewTab { get; set; }
        [Multipart("page_url")] string PageUrl { get; set; }
        [Multipart("position")] int? Position { get; set; }
        [Multipart("title")] string Title { get; set; }
        [Multipart("type")] IEnumerable<ModuleItemTypes> Type { get; set; }
    }
}