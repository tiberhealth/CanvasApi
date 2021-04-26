using System;
using System.Linq;
using CanvasApi.Client.Pages.Enums;
using Newtonsoft.Json;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Pages.Models.Concrete
{
    internal class WikiPage : IWikiPage
    {
        [JsonProperty("title")] public string Title { get; set; }
        [JsonProperty("body")] public string Body { get; set; }

        [Multipart("editing_roles", EnumAsString = true, EnumerationAsXsv = true, EnumerationDelimiter = ","), JsonProperty("editing_roles")]
        public EditingRoles[] EditingRoles { get; set; }

        [JsonProperty("notify_of_update")] public bool NotifyOfUpdate { get; set; }
        [JsonProperty("published")] public bool Publish { get; set; }
        [JsonProperty("front_page")] public bool FrontPage { get; set; }
    }
}
