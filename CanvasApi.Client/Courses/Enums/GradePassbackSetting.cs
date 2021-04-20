using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Enums
{
    public enum GradePassbackSetting
    {
        [EnumSerializedValue("nightly_sync")] NightlySync,
        [EnumSerializedValue("disabled")] Disabled
    }
}
