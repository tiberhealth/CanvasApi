using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class MasteryPathSelectOptions : IMasteryPathSelectOptions
    {
        public long? AssignmentSetId { get; set; }
        public long? StudentId { get; set; }
    }
}
