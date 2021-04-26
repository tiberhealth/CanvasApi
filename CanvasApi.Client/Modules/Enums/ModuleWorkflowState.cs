using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [Multipart(EnumAsString = true)]
    public enum ModuleWorkflowState
    {
        [EnumSerializedValue("active")] MustView,
        [EnumSerializedValue("deleted")] MustSubmit
    }
}
