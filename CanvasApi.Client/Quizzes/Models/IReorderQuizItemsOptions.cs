﻿namespace CanvasApi.Client.Quizzes.Models;

public interface IReorderQuizItemsOptions
{
    IEnumerable<IQuizItemsOrderDetail> Order { get; }
}