using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItem
    {
        [JsonProperty("completion_requirement")] ICompletionRequirement CompletionRequirement { get; set; }
        [JsonProperty("content_details")] IContentDetails ContentDetails { get; set; }
        [JsonProperty("content_id")] long? ContentId { get; set; }
        [JsonProperty("external_url")] string ExternalUrl { get; set; }
        [JsonProperty("html_url")] string HtmlUrl { get; set; }
        [JsonProperty("id")] long? Id { get; set; }
        [JsonProperty("indent")] int? Indent { get; set; }
        [JsonProperty("module_id")] long? ModuleId { get; set; }
        [JsonProperty("new_tab")] bool? NewTab { get; set; }
        [JsonProperty("page_url")] string PageUrl { get; set; }
        [JsonProperty("position")] int? Position { get; set; }
        [JsonProperty("published")] bool? Published { get; set; }
        [JsonProperty("title")] string Title { get; set; }
        [JsonProperty("type")] IEnumerable<ModuleTypes> Type { get; set; }
        [JsonProperty("url")] string Url { get; set; }
    }
}