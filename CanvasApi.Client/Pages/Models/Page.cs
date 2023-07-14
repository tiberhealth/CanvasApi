using System;
using CanvasApi.Client.Pages.Enums;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.Pages.Models
{
    public class Page : IPage
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? HideFromStudents { get; set; }
        public EditingRoles[] EditingRoles { get; set; }
        public string LastEditedBy { get; set; }
        public string Body { get; set; }
        public bool? Published { get; set; }
        public bool? FrontPage { get; set; }
        public bool? LockedForUser { get; set; }
        public JObject LockInfo { get; set; }
        public string LockExplanation { get; set; }
    }
}
