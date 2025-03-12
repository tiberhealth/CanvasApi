namespace CanvasApi.Client.Wikis.Models;

internal class Page : IPage
{
    public long PageId { get; set; }
    public string Url { get; set; }
    public string Title { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool HideFromStudents { get; set; }
    public string EditingRoles { get; set; }
    public string LastEditedBy { get; set; }
    public string Body { get; set; }
    public bool Published { get; set; }
    public DateTime? PublishAt { get; set; }
    public bool FrontPage { get; set; }
    public bool LockedForUser { get; set; }
    public string LockInfo { get; set; }
    public string LockExplanation { get; set; }
}
