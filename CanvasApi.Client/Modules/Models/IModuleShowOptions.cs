using CanvasApi.Client.Modules.Models.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IModuleShowOptions
    {
        [Multipart("include")] IEnumerable<ModuleInclude> Include { get; set; }
        [Multipart("student_id")] long? StudentId { get; set; }
    }
}