using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Enums
{
    [EnumAsString]
    public enum ScoringPolicyTypes
    {
        [EnumSerializedValue("keep_highest")] KeepHighest,
        [EnumSerializedValue("keep_latest")] KeepLatest
    }
}
