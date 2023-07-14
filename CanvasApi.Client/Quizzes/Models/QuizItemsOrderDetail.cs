using CanvasApi.Client.Quizzes.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Quizzes.Models
{
    internal class QuizItemsOrderDetail : IQuizItemsOrderDetail
    {
        public int Id { get; set; }
        public QuizItemTypes Type { get; set; }
    }
}
