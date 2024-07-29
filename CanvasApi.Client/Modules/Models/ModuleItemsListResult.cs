using System.Collections.Generic;
using System.Linq;

namespace CanvasApi.Client.Modules.Models
{
    class ModuleItemsListResult
    {
        public IEnumerable<ModuleItem> ModuleItems { get; set; }

        public static IEnumerable<ModuleItem> ToArray(ModuleItemsListResult apiResult) => apiResult.ModuleItems.ToArray();
    }
}
