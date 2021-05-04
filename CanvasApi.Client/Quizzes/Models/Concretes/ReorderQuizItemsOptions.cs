using CanvasApi.Client.Quizzes.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Models.Concretes
{
    internal class ReorderQuizItemsOptions : IReorderQuizItemsOptions
    {
        IEnumerable<IQuizItemsOrderDetail> IReorderQuizItemsOptions.Order => this.Order;
        internal IEnumerable<IQuizItemsOrderDetail> Order { get; init; }
    }
}
