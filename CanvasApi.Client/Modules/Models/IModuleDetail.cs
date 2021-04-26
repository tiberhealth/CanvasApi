using System;
using System.Collections.Generic;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal interface IModuleDetail
    {
        string Name { get; set; }
        int? Position { get; set; }
        IEnumerable<int> PrerequisiteModuleIds { get; set; }
        bool? Published { get; set; }
        bool? PublishFinalGrade { get; set; }
        bool? RequireSequentialProgress { get; set; }
        DateTime? UnlockAt { get; set; }
    }
}