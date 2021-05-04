using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Quizzes.Models.Concretes
{
    internal class QuizCreateEditOptions : IQuizCreateEditOptions
    {
        IQuizDetail IQuizCreateEditOptions.Quiz => this.Quiz;
        internal IQuizDetail Quiz { get; init; }
    }
}
