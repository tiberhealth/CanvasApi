namespace CanvasApi.Client.Accounts.Models
{
    public class HelpLinksClass
    {
        ///<summary>
        /// Help link button title
        /// </summary>
        public string HelpLinkName { get; set; }

        ///<summary>
        /// Help link button icon
        /// </summary>
        public string HelpLinkIcon { get; set; }

        ///<summary>
        /// Help links defined by the account. Could include default help links.
        /// </summary>
        public HelpLink[] CustomHelpLinks { get; set; }

        ///<summary>
        /// Default help links provided when account has not set help links of their own.
        /// </summary>
        public HelpLink[] HelpLinks { get; set; }
    }
}
