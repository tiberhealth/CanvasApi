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
        [Multipart("prev")] public ModuleItem Prev { get; set; }
        IModuleItem IModuleItemSequenceNode.Prev => this.Prev;
        [Multipart("current")] public ModuleItem Current { get; set; }
        IModuleItem IModuleItemSequenceNode.Current => this.Current;
        [Multipart("next")] public ModuleItem Next { get; set; }
        IModuleItem IModuleItemSequenceNode.Next => this.Next;
        [Multipart("mastery_path")] public MasteryPath MasteryPath { get; set; }
        IMasteryPath IModuleItemSequenceNode.MasteryPath => this.MasteryPath;
    }
}
