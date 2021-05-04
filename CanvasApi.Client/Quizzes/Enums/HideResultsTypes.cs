using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Enums
{
    [EnumAsString]
    public enum HideResultsTypes
    {
        [EnumSerializedValue("always")] Always,
        [EnumSerializedValue("until_after_last_attempt")] UntilAfterLastAttempt
    }
}
