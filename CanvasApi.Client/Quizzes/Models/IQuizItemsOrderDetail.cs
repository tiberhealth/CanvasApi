using CanvasApi.Client.Quizzes.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Models
{
    public interface IQuizItemsOrderDetail
    {
        [Multipart("id")] int Id { get; set; }
        [Multipart("type")] QuizItemTypes Type { get; set; }
    }
}
