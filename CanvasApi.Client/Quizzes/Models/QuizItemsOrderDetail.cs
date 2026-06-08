namespace CanvasApi.Client.Quizzes.Models;

internal class QuizItemsOrderDetail : IQuizItemsOrderDetail
{
    public int Id { get; set; }
    public QuizItemTypes Type { get; set; }
}