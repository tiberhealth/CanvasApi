using System;
using System.Runtime.Serialization;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Pages.Enums
{
    public enum PageSort
    {
        [EnumSerializedValue("title")] Title,
        [EnumSerializedValue("created_at")] CreatedAt,
        [EnumSerializedValue("updated_at")] UpdatedAt
    }
}
