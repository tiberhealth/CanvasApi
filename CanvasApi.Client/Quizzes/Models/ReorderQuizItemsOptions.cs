using CanvasApi.Client.Quizzes.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Models
{
    internal class ReorderQuizItemsOptions : IReorderQuizItemsOptions
    {
        IEnumerable<IQuizItemsOrderDetail> IReorderQuizItemsOptions.Order => Order;
        internal IEnumerable<IQuizItemsOrderDetail> Order { get; init; }
    }
}
