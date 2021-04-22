using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [Multipart(EnumAsString = true)]
    public enum AdminListWorkflowState
    {
        [EnumSerializedValue("active")] Active,
        [EnumSerializedValue("deleted")] Deleted,
        [EnumSerializedValue("all")] All
    }
}
