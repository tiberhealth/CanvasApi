namespace CanvasApi.Client.Assignments.Models
{
    public interface ITurnItInSettings
    {
        string OriginalityReportVisibility { get; }
        bool? SPaperCheck { get; }
        bool? InternetCheck { get; }
        bool? JournalCheck { get; }
        bool? ExcludeBiblio { get; }
        bool? ExcludeQuoted { get; }
        string ExcludeSmallMatchesType { get; }
        decimal? ExcludeSmallMatchesValue { get; }
    }
}
