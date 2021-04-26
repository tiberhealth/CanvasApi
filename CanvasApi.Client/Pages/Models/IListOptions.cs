using CanvasApi.Client.Pages.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Pages.Models
{
    public interface IListOptions
    {
        [Multipart("sort")] PageSort Sort { get; set;}
        [Multipart("order")] SortOrder Order { get; set; }
        [Multipart("search_term")] string SearchTerm { get; set; }
        [Multipart("published")] bool Published { get; set; }
    }
}
