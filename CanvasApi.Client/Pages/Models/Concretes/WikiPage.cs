using CanvasApi.Client.Pages.Enums;
using Newtonsoft.Json;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Pages.Models.Concrete
{
    internal class WikiPage : IWikiPage
    {
        [Multipart("title")] public string Title { get; set; }
        [Multipart("body")] public string Body { get; set; }

        [Multipart("editing_roles", EnumAsString = true, EnumerationAsXsv = true, EnumerationDelimiter = ","), JsonProperty("editing_roles")]
        public EditingRoles[] EditingRoles { get; set; }

        [Multipart("notify_of_update")] public bool NotifyOfUpdate { get; set; }
        [Multipart("published")] public bool Publish { get; set; }
        [Multipart("front_page")] public bool FrontPage { get; set; }
    }
}
