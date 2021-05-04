using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Models
{
    public interface IQuizCreateEditOptions
    {
        [Multipart("quiz")] IQuizDetail Quiz { get; }
    }
}
