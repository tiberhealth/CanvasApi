using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItem : IModuleItem
    {
        [Multipart("id")] public long? Id { get; set; }
        [Multipart("module_id")] public long? ModuleId { get; set; }
        [Multipart("position")] public int? Position { get; set; }
        [Multipart("title")] public string Title { get; set; }
        [Multipart("indent")] public int? Indent { get; set; }
        [Multipart("type")] public IEnumerable<ModuleItemTypes> Type { get; set; }
        [Multipart("content_id")] public long? ContentId { get; set; }
        [Multipart("html_url")] public string HtmlUrl { get; set; }
        [Multipart("url")] public string Url { get; set; }
        [Multipart("page_url")] public string PageUrl { get; set; }
        [Multipart("external_url")] public string ExternalUrl { get; set; }
        [Multipart("new_tab")] public bool? NewTab { get; set; }
        [Multipart("completion_requirement")] public CompletionRequirement CompletionRequirement { get; set; }
        ICompletionRequirement IModuleItem.CompletionRequirement => this.CompletionRequirement;
        [Multipart("content_details")] public ContentDetails ContentDetails { get; set; }
        IContentDetails IModuleItem.ContentDetails => this.ContentDetails;
        [Multipart("published")] public bool? Published { get; set; }
    }
}
