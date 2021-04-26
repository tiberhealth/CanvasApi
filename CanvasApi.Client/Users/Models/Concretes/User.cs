using CanvasApi.Client.Enrollments.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Users.Models.Concrete
{
    internal class User : IUser
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("sortable_name")] public string SortableName  { get; set; }
        [JsonProperty("short_name")] public string ShortName  { get; set; }
        [JsonProperty("sis_user_id")] public string SisUserId  { get; set; }
        [JsonProperty("sis_import_id")] public long SisImportId  { get; set; }
        [JsonProperty("integration_id")] public string IntegrationId  { get; set; }
        [JsonProperty("login_id")] public string LoginId  { get; set; }
        [JsonProperty("avatar_url")] public string AvatarUrl  { get; set; }
        [JsonProperty("enrollments")] public IEnumerable<IEnrollment> Enrollments  { get; set; }
        [JsonProperty("email")] public string Email  { get; set; }
        [JsonProperty("locale")] public string Locale  { get; set; }
        [JsonProperty("last_login")] public DateTime? LastLogin  { get; set; }
        [JsonProperty("time_zone")] public string TimeZone  { get; set; }
        [JsonProperty("bio")] public string Bio  { get; set; }
    }
}
