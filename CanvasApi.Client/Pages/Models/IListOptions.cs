namespace CanvasApi.Client.Pages.Models;

public interface IListOptions
{
    PageSort Sort { get; set;}
    SortOrder Order { get; set; }
    string SearchTerm { get; set; }
    bool Published { get; set; }
}