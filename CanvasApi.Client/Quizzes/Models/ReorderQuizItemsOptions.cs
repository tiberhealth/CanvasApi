namespace CanvasApi.Client.Quizzes.Models;

internal class ReorderQuizItemsOptions : IReorderQuizItemsOptions
{
    IEnumerable<IQuizItemsOrderDetail> IReorderQuizItemsOptions.Order => this.Order;
    internal IEnumerable<IQuizItemsOrderDetail> Order { get; init; }
}