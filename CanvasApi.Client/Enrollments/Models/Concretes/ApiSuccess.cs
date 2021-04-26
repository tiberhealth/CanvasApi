using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Enrollments.Models.Concretes
{
    internal class ApiSuccess: IApiSuccess
    {
        [JsonProperty("success")] public bool? Success { get; set; }
    }
}
