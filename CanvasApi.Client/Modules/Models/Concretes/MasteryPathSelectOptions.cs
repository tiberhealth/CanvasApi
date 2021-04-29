using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class MasteryPathSelectOptions : IMasteryPathSelectOptions
    {
        public long? AssignmentSetId { get; set; }
        public long? StudentId { get; set; }
    }
}
