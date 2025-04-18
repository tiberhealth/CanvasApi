﻿namespace CanvasApi.Client.Modules.Models;

internal class ModuleListOptions : IModuleListOptions
{
    public IEnumerable<ModuleInclude> Include { get; set; }
    public string SearchTerm { get; set; }
    public long? StudentId { get; set; }
}