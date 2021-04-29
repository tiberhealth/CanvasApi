using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModulesListResult
    {
        public IEnumerable<Module> Modules { get; set; }

        public static IEnumerable<Module> ToArray(ModulesListResult apiResult) => apiResult.Modules.ToArray();
    }
}
