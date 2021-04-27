using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItem
    {
        [Multipart("completion_requirement")] ICompletionRequirement CompletionRequirement { get; set; }
        [Multipart("content_details")] IContentDetails ContentDetails { get; set; }
        [Multipart("content_id")] long? ContentId { get; set; }
        [Multipart("external_url")] string ExternalUrl { get; set; }
        [Multipart("html_url")] string HtmlUrl { get; set; }
        [Multipart("id")] long? Id { get; set; }
        [Multipart("indent")] int? Indent { get; set; }
        [Multipart("module_id")] long? ModuleId { get; set; }
        [Multipart("new_tab")] bool? NewTab { get; set; }
        [Multipart("page_url")] string PageUrl { get; set; }
        [Multipart("position")] int? Position { get; set; }
        [Multipart("published")] bool? Published { get; set; }
        [Multipart("title")] string Title { get; set; }
        [Multipart("type")] IEnumerable<ModuleTypes> Type { get; set; }
        [Multipart("url")] string Url { get; set; }
    }
}