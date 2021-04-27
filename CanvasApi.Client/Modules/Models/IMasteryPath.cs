using Newtonsoft.Json;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IMasteryPath
    {
        [Multipart("assignment_sets")] IEnumerable<int> AssignmentSets { get; set; }
        [Multipart("awaiting_choice")] bool? AwaitingChoice { get; set; }
        [Multipart("choose_url")] string ChooseUrl { get; set; }
        [Multipart("locked")] bool? Locked { get; set; }
        [Multipart("modules_tab_disabled")] bool? ModulesTabDisabled { get; set; }
        [Multipart("modules_url")] string ModulesUrl { get; set; }
        [Multipart("selected_set_id")] int? SelectedSetId { get; set; }
        [Multipart("still_processing")] bool? StillProcessing { get; set; }
    }
}