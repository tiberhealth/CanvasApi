using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Enums
{
    [EnumAsString]
    public enum QuizTypes
    {
        [EnumSerializedValue("practice_quiz")] PracticeQuiz,
        [EnumSerializedValue("assignment")] Assignment,
        [EnumSerializedValue("graded_survey")] GradedSurvey,
        [EnumSerializedValue("survey")] Survey
    }
}
