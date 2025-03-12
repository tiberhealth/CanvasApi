﻿namespace CanvasApi.Client.Modules.Models;

internal class ModuleItemListOptions : IModuleItemListOptions
{
    public IEnumerable<ModuleItemInclude> Include { get; set; }
    public string SearchTerm { get; set; }
    public long? StudentId { get; set; }
}