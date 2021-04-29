using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    class ModuleItemsListResult
    {
        public IEnumerable<ModuleItem> ModuleItems { get; set; }

        public static IEnumerable<ModuleItem> ToArray(ModuleItemsListResult apiResult) => apiResult.ModuleItems.ToArray();
    }
}
