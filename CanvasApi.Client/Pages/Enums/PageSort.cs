using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Pages.Enums
{
    [EnumAsString]
    public enum PageSort
    {
        [EnumSerializedValue("title")] Title,
        [EnumSerializedValue("created_at")] CreatedAt,
        [EnumSerializedValue("updated_at")] UpdatedAt
    }
}
