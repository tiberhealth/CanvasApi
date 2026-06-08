namespace CanvasApi.Client.Quizzes.Models;

internal class QuizPermissions : IQuizPermissions
{
    public bool? Read { get; set; }
    public bool? Submit { get; set; }
    public bool? Create { get; set; }
    public bool? Manage { get; set; }
    public bool? ReadStatistics { get; set; }
    public bool? ReviewGrades { get; set; }
    public bool? Update { get; set; }
}