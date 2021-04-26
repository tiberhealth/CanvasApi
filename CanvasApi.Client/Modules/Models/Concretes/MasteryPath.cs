using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class MasteryPath : IMasteryPath
    {
        [JsonProperty("locked")] public bool? Locked { get; set; }
        [JsonProperty("assignment_sets")] public IEnumerable<Int32> AssignmentSets { get; set; }
        [JsonProperty("selected_set_id")] public int? SelectedSetId { get; set; }
        [JsonProperty("awaiting_choice")] public bool? AwaitingChoice { get; set; }
        [JsonProperty("still_processing")] public bool? StillProcessing { get; set; }
        [JsonProperty("modules_url")] public string ModulesUrl { get; set; }
        [JsonProperty("choose_url")] public string ChooseUrl { get; set; }
        [JsonProperty("modules_tab_disabled")] public bool? ModulesTabDisabled { get; set; }
    }
}
