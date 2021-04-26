using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [EnumAsString]
    public enum  CompletionRequirementTypes
    {
        [EnumSerializedValue("must_view")] MustView,
        [EnumSerializedValue("must_submit")] MustSubmit,
        [EnumSerializedValue("must_contribute")] MustContribute,
        [EnumSerializedValue("min_score")] MinScore,
        [EnumSerializedValue("must_mark_done")] MustMarkDone
    }
}
