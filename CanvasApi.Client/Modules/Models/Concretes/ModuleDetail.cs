using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleDetail : IModuleDetail
    {
        public string Name { get; set; }
        public DateTime? UnlockAt { get; set; }
        public int? Position { get; set; }
        public bool? RequireSequentialProgress { get; set; }
        public IEnumerable<int> PrerequisiteModuleIds { get; set; }
        public bool? PublishFinalGrade { get; set; }
        public bool? Published { get; set; }
    }
}
