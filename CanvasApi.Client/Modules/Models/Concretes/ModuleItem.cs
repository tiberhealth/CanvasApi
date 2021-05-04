﻿using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class ModuleItem : IModuleItem
    {
        public long Id { get; set; }
        public long? ModuleId { get; set; }
        public int? Position { get; set; }
        public string Title { get; set; }
        public int? Indent { get; set; }
        public ModuleItemTypes Type { get; set; }
        public long? ContentId { get; set; }
        public string HtmlUrl { get; set; }
        public string Url { get; set; }
        public string PageUrl { get; set; }
        public string ExternalUrl { get; set; }
        public bool? NewTab { get; set; }

        public CompletionRequirement CompletionRequirement { get; set; }
        ICompletionRequirement IModuleItem.CompletionRequirement => this.CompletionRequirement;

        public ContentDetails ContentDetails { get; set; }
        IContentDetails IModuleItem.ContentDetails => this.ContentDetails;

        public bool? Published { get; set; }
    }
}
