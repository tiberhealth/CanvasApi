using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [Multipart(EnumAsString = true)]
    public enum  CompletionRequirementTypes
    {
        [EnumSerializedValue("must_view")] MustView,
        [EnumSerializedValue("must_submit")] MustSubmit,
        [EnumSerializedValue("must_contribute")] MustContribute,
        [EnumSerializedValue("min_score")] MinScore,
        [EnumSerializedValue("must_mark_done")] MustMarkDone
    }
}
