using CanvasApi.Client.Modules.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleCreateUpdateOptions
    {
        IModuleDetail Module { get; }
    }
}
