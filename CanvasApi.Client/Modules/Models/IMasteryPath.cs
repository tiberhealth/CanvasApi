using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IMasteryPath
    {
        [Multipart("assignment_sets")] IEnumerable<JObject> AssignmentSets { get; }
        [Multipart("awaiting_choice")] bool? AwaitingChoice { get; }
        [Multipart("choose_url")] string ChooseUrl { get; }
        [Multipart("locked")] bool? Locked { get; }
        [Multipart("modules_tab_disabled")] bool? ModulesTabDisabled { get; }
        [Multipart("modules_url")] string ModulesUrl { get; }
        [Multipart("selected_set_id")] long? SelectedSetId { get; }
        [Multipart("still_processing")] bool? StillProcessing { get; }
    }
}