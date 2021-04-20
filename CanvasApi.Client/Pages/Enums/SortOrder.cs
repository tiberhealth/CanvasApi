using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Pages.Enums
{
    public enum SortOrder
    {
        [EnumSerializedValue("asc")] Ascending,
        [EnumSerializedValue("desc")] Descending
    }
}
