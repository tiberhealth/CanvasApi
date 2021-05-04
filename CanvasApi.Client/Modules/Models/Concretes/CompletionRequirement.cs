using CanvasApi.Client.Helpers;
using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class CompletionRequirement : ICompletionRequirement
    {
        [JsonProperty("type")] internal string TypeJson
        {
            get => this.CompletionType.ToSnake();
            set => this.CompletionType = value.ToEnum<CompletionRequirementTypes>();
        }

        public int? MinScore { get; set; }
        public bool? Completed { get; set; }

        [Multipart("type")] public CompletionRequirementTypes? CompletionType { get; set; }
    }
}
