namespace CanvasApi.Client.Pages.Models;

internal class WikiPage : IWikiPage
{
    public string Title { get; set; }
    public string Body { get; set; }

    public EditingRoles[] EditingRoles { get; set; }

    public bool NotifyOfUpdate { get; set; }
    public bool Publish { get; set; }
    public bool FrontPage { get; set; }
}