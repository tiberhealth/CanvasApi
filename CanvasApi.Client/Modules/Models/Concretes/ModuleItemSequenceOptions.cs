using CanvasApi.Client.Modules.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItemSequenceOptions : IModuleItemSequenceOptions
    {
        public IEnumerable<ModuleItemSequenceAssetTypes> AssetType { get; set; }
        public long? AssetId { get; set; }
    }
}
