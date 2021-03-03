using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Courses.Models
{
    internal class CalendarLink : ICalendarLink
    {
        [JsonProperty("ics")] public string Ics { get; set; }
    }
}
