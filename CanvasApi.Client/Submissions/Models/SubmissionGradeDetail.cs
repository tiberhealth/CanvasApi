namespace CanvasApi.Client.Submissions.Models;

internal class SubmissionGradeDetail : ISubmissionGradeDetail
{
    public string PostedGrade { get; set; }
    public bool? Excuse { get; set; }
    public string LatePolicyStatus { get; set; }
    public int? SecondsLateOverride { get; set; }
    public string Sticker { get; set; }
}
