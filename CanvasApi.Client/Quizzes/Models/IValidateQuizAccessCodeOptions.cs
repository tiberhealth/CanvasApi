using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Models
{
    public interface IValidateQuizAccessCodeOptions
    {
        [Multipart("access_code")] string AccessCode { get; set; }
    }
}
