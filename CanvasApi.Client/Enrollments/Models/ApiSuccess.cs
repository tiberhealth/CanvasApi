using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Enrollments.Models
{
    internal class ApiSuccess: IApiSuccess
    {
        [JsonProperty("success")] public bool? Success { get; set; }
    }
}
