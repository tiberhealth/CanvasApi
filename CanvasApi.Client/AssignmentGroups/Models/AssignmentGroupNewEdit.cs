using System;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.AssignmentGroups.Models
{
    internal class AssignmentGroupNewEdit : IAssignmentGroupNewEdit
    {
        public string Name { get; set; }
        public int? Position { get; set; }
        public decimal? GroupWeight { get; set; }
        public string SisSourceId { get; set; }
        public JObject IntegrationData { get; set; }
        public string Rules { get; set; }
    }
}
