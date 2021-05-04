using CanvasApi.Client.Pages.Enums;
using Newtonsoft.Json;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Pages.Models.Concrete
{
    internal class WikiPage : IWikiPage
    {
        public string Title { get; set; }
        public string Body { get; set; }

                public EditingRoles[] EditingRoles { get; set; }

        public bool NotifyOfUpdate { get; set; }
        public bool Publish { get; set; }
        public bool FrontPage { get; set; }
    }
}
