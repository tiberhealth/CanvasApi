using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class MasteryPath : IMasteryPath
    {
        [Multipart("locked")] public bool? Locked { get; set; }
        [Multipart("assignment_sets")] public IEnumerable<JObject> AssignmentSets { get; set; }
        [Multipart("selected_set_id")] public long? SelectedSetId { get; set; }
        [Multipart("awaiting_choice")] public bool? AwaitingChoice { get; set; }
        [Multipart("still_processing")] public bool? StillProcessing { get; set; }
        [Multipart("modules_url")] public string ModulesUrl { get; set; }
        [Multipart("choose_url")] public string ChooseUrl { get; set; }
        [Multipart("modules_tab_disabled")] public bool? ModulesTabDisabled { get; set; }
    }
}
