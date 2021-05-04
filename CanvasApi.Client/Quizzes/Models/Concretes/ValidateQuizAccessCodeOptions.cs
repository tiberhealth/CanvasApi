using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Quizzes.Models.Concretes
{
    internal class ValidateQuizAccessCodeOptions : IValidateQuizAccessCodeOptions
    {
        public string AccessCode { get; set; }
    }
}
