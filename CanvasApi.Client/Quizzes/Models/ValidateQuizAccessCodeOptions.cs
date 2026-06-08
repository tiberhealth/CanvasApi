namespace CanvasApi.Client.Quizzes.Models;

internal class ValidateQuizAccessCodeOptions : IValidateQuizAccessCodeOptions
{
    public string AccessCode { get; set; }
}