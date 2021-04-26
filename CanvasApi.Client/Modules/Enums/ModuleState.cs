using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [Multipart(EnumAsString = true)]
    public enum ModuleState
    {
        [EnumSerializedValue("locked")] Locked,
        [EnumSerializedValue("unlocked")] Unlocked,
        [EnumSerializedValue("started")] Started,
        [EnumSerializedValue("completed")] Completed
    }
}
