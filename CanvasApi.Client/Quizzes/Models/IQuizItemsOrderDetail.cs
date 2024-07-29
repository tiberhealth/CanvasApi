using CanvasApi.Client.Quizzes.Enums;

namespace CanvasApi.Client.Quizzes.Models
{
    public interface IQuizItemsOrderDetail
    {
        int Id { get; set; }
        QuizItemTypes Type { get; set; }
    }
}
