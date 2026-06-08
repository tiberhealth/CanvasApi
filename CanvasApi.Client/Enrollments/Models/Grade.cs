namespace CanvasApi.Client.Enrollments.Models;

internal class Grade : IGrade
{
    public string HtmlUrl { get; set; }
    public string CurrentGrade { get; set; }
    public string FinalGrade { get; set; }
    public string CurrentScore { get; set; }
    public string FinalScore { get; set; }
    public decimal? CurrentPoints { get; set; }
    public string UnpostedCurrentGrade { get; set; }
    public string UnpostedFinalGrade { get; set; }
    public string UnpostedCurrentScore { get; set; }
    public string UnpostedFinalScore { get; set; }
    public decimal? UnpostedCurrentPoints { get; set; }
}