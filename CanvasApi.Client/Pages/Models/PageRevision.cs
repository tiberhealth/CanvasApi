using System;

namespace CanvasApi.Client.Pages.Models
{
    public class PageRevision : IPageRevision
    {
        public long RevisionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? Latest { get; set; }
        public string EditedBy { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
