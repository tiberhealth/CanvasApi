using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CanvasApi.Client.Modules.Models
{
    internal class MasteryPath : IMasteryPath
    {
        public bool? Locked { get; set; }
        public IEnumerable<JObject> AssignmentSets { get; set; }
        public long? SelectedSetId { get; set; }
        public bool? AwaitingChoice { get; set; }
        public bool? StillProcessing { get; set; }
        public string ModulesUrl { get; set; }
        public string ChooseUrl { get; set; }
        public bool? ModulesTabDisabled { get; set; }
    }
}
