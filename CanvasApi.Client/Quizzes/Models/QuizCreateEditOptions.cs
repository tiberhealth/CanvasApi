namespace CanvasApi.Client.Quizzes.Models;

internal class QuizCreateEditOptions : IQuizCreateEditOptions
{
    IQuizDetail IQuizCreateEditOptions.Quiz => Quiz;
    internal IQuizDetail Quiz { get; init; }
}