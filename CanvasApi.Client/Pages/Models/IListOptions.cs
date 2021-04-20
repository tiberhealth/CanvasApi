using System;
using CanvasApi.Client.Pages.Enums;
using Newtonsoft.Json;

namespace CanvasApi.Client.Pages.Models
{
    public interface IListOptions
    {
        [JsonProperty("sort")] PageSort Sort { get; set;}
        [JsonProperty("order")] SortOrder Order { get; set; }
        [JsonProperty("search_term")] string SearchTerm { get; set; }
        [JsonProperty("published")] bool Published { get; set; }
    }
}
