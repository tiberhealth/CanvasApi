using System.Collections.Generic;

namespace CanvasApi.Client.Quizzes.Models
{
    internal class ReorderQuizItemsOptions : IReorderQuizItemsOptions
    {
        IEnumerable<IQuizItemsOrderDetail> IReorderQuizItemsOptions.Order => Order;
        internal IEnumerable<IQuizItemsOrderDetail> Order { get; init; }
    }
}
