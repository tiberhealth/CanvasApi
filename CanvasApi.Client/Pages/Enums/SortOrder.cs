using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Pages.Enums
{
    [EnumAsString]
    public enum SortOrder
    {
        [EnumSerializedValue("asc")] Ascending,
        [EnumSerializedValue("desc")] Descending
    }
}
