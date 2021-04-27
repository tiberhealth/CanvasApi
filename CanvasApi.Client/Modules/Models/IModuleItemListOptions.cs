using CanvasApi.Client.Modules.Models.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleItemListOptions
    {
        [Multipart("include")] IEnumerable<ModuleItemInclude> Include { get; set; }
        [Multipart("search_term")] string SearchTerm { get; set; }
        [Multipart("student_id")] long? StudentId { get; set; }
    }
}