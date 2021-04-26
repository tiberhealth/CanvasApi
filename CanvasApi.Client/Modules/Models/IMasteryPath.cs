using Newtonsoft.Json;
using System.Collections.Generic;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IMasteryPath
    {
        [JsonProperty("assignment_sets")] IEnumerable<int> AssignmentSets { get; set; }
        [JsonProperty("awaiting_choice")] bool? AwaitingChoice { get; set; }
        [JsonProperty("choose_url")] string ChooseUrl { get; set; }
        [JsonProperty("locked")] bool? Locked { get; set; }
        [JsonProperty("modules_tab_disabled")] bool? ModulesTabDisabled { get; set; }
        [JsonProperty("modules_url")] string ModulesUrl { get; set; }
        [JsonProperty("selected_set_id")] int? SelectedSetId { get; set; }
        [JsonProperty("still_processing")] bool? StillProcessing { get; set; }
    }
}