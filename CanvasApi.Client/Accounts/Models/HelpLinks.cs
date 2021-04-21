using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Accounts.Models
{
    public class HelpLinks
    {
        ///<summary>
        /// Help link button title
        /// </summary>
        [JsonProperty("help_link_name")] public string HelpLinkName { get; set; }

        ///<summary>
        /// Help link button icon
        /// </summary>
        [JsonProperty("help_link_icon")] public string helpLinkIcon { get; set; }

        ///<summary>
        /// Help links defined by the account. Could include default help links.
        /// </summary>
        [JsonProperty("custom_help_links")] public HelpLink[] CustomHelpLinks { get; set; }

        ///<summary>
        /// Default help links provided when account has not set help links of their own.
        /// </summary>
        [JsonProperty("default_help_links")] public HelpLink[] helpLinks { get; set; }
    }
}
