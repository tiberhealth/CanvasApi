namespace CanvasApi.Client.Modules.Models;

internal class CompletionRequirement : ICompletionRequirement
{
    [JsonProperty("type")]
    internal string TypeJson
    {
        get => CompletionType.ToSnake();
        set => CompletionType = value.ToEnum<CompletionRequirementTypes>();
    }

    public int? MinScore { get; set; }
    public bool? Completed { get; set; }

    [Multipart("type")] public CompletionRequirementTypes? CompletionType { get; set; }
}