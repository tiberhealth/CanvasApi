using CanvasApi.Client.Modules.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class ModuleItemSequenceOptions : IModuleItemSequenceOptions
    {
        public ModuleItemSequenceAssetTypes AssetType { get; set; }
        public long? AssetId { get; set; }
    }
}
