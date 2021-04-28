﻿using CanvasApi.Client.Modules.Models.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IModuleListOptions
    {
        /// <summary>
        /// “items”: Return module items inline if possible. This parameter suggests that Canvas return module items directly in the Module object JSON, to avoid having to make separate API requests for each module when enumerating modules and items. Canvas is free to omit 'items' for any particular module if it deems them too numerous to return inline. Callers must be prepared to use the List Module Items API if items are not returned.
        /// 
        /// “content_details”: Requires 'items'. Returns additional details with module items specific to their associated content items. Includes standard lock information for each item.
        /// 
        /// Allowed values: <see cref="ModuleInclude"/>
        /// </summary>
        [Multipart("include")] IEnumerable<ModuleInclude> Include { get; set; }
        /// <summary>
        /// The partial name of the modules (and module items, if 'items' is specified with include[]) to match and return.
        /// </summary>
        [Multipart("search_term")] string SearchTerm { get; set; }
        /// <summary>
        /// Returns module completion information for the student with this id.
        /// </summary>
        [Multipart("student_id")] long? StudentId { get; set; }
    }
}