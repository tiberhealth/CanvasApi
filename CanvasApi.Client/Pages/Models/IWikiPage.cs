using System;
using System.Text.Json.Serialization;
using CanvasApi.Client.Pages.Enums;
using Newtonsoft.Json;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Pages.Models
{
    public interface IWikiPage
    {
        /// <summary>
        /// The title for the new page. NOTE: changing a page's title will change its url. The updated url will be returned in the result.
        /// </summary>
        [JsonProperty("title")] string Title { get; set; }
        /// <summary>
        /// The content for the new page.
        /// </summary>
        [JsonProperty("body")] string Body { get; set; }
        /// <summary>
        /// Which user roles are allowed to edit this page. Any combination of these roles is allowed (separated by commas).
        /// “teachers”
        /// Allows editing by teachers in the course.
        /// 
        /// “students”
        /// Allows editing by students in the course.
        /// 
        /// “members”
        /// For group wikis, allows editing by members of the group.
        /// 
        /// “public”
        /// Allows editing by any user.
        /// 
        /// Allowed values:
        /// teachers, students, members, public
        /// </summary>
        [Multipart("editing_roles", EnumAsString = true, EnumerationAsXsv = true, EnumerationDelimiter = ","), JsonProperty("editing_roles")]
        EditingRoles[] EditingRoles { get; set; }
        /// <summary>
        /// Whether participants should be notified when this page changes
        /// </summary>
        [JsonProperty("notify_of_update")] bool NotifyOfUpdate { get; set; }
        /// <summary>
        /// Whether the page is published (true) or draft state (false).
        /// </summary>
        [JsonProperty("published")] bool Publish { get; set; }
        /// <summary>
        /// Set an unhidden page as the front page (if true)
        /// </summary>
        [JsonProperty("front_page")] bool FrontPage { get; set; }
    }
}
