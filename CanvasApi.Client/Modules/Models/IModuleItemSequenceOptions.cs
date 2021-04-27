using CanvasApi.Client.Modules.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItemSequenceOptions
    {
        [Multipart("asset_type")] IEnumerable<ModuleItemSequenceAssetTypes> AssetType { get; set; }
        [Multipart("asset_id")] long? AssetId { get; set; }
    }
}