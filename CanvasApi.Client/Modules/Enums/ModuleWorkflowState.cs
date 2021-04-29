using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [EnumAsString]
    public enum ModuleWorkflowState
    {
        [EnumSerializedValue("must_view")] MustView,
        [EnumSerializedValue("must_submit")] MustSubmit,
        [EnumSerializedValue("must_contribute")] MustContribute,
        [EnumSerializedValue("must_mark_done")] MustMarkDone
    }
}
