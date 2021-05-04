using CanvasApi.Client.Quizzes.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Models
{
    public interface IQuizItemsOrderDetail
    {
        int Id { get; set; }
        QuizItemTypes Type { get; set; }
    }
}
