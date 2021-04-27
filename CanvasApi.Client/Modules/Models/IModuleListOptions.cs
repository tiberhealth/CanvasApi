using CanvasApi.Client.Modules.Models.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IModuleListOptions
    {
        [Multipart("include")] IEnumerable<ModuleInclude> Include { get; set; }
        [Multipart("search_term")] string SearchTerm { get; set; }
        [Multipart("student_id")] long? StudentId { get; set; }
    }
}