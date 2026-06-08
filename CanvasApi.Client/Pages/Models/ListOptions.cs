namespace CanvasApi.Client.Pages.Models;

public class ListOptions : IListOptions
{
    public PageSort Sort { get; set; }
    public SortOrder Order { get; set; }
    public string SearchTerm { get; set; }
    public bool Published { get; set; }
}