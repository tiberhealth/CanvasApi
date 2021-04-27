using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItemSequenceNode : IModuleItemSequenceNode
    {
        [Multipart("prev")] public IModuleItem Prev { get; set; }
        [Multipart("current")] public IModuleItem Current { get; set; }
        [Multipart("next")] public IModuleItem Next { get; set; }
        [Multipart("mastery_path")] public IMasteryPath MasteryPath { get; set; }
    }
}
