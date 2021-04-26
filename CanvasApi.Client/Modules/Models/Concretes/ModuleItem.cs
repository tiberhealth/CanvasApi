using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class ModuleItem : IModuleItem
    {
        [JsonProperty("id")] public long? Id { get; set; }
        [JsonProperty("module_id")] public long? ModuleId { get; set; }
        [JsonProperty("position")] public int? Position { get; set; }
        [JsonProperty("title")] public string Title { get; set; }
        [JsonProperty("indent")] public int? Indent { get; set; }
        [JsonProperty("type")] public IEnumerable<ModuleTypes> Type { get; set; }
        [JsonProperty("content_id")] public long? ContentId { get; set; }
        [JsonProperty("html_url")] public string HtmlUrl { get; set; }
        [JsonProperty("url")] public string Url { get; set; }
        [JsonProperty("page_url")] public string PageUrl { get; set; }
        [JsonProperty("external_url")] public string ExternalUrl { get; set; }
        [JsonProperty("new_tab")] public bool? NewTab { get; set; }
        [JsonProperty("completion_requirement")] public ICompletionRequirement CompletionRequirement { get; set; }
        [JsonProperty("content_details")] public IContentDetails ContentDetails { get; set; }
        [JsonProperty("published")] public bool? Published { get; set; }
    }
}
