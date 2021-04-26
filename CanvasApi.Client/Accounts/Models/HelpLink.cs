namespace CanvasApi.Client.Accounts.Models
{
    public class HelpLink
    {
        /// <summary>
        /// The ID of the help link
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The name of the help link
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The description of the help link
        /// </summary>
        public string Subtext { get; set; }

        /// <summary>
        /// The URL of the help link
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The type of the help link
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The roles that have access to this help link
        /// "user", "student", "teacher", "admin", "observer", "unenrolled"
        /// </summary>
        public string AvailableTo { get; set; }
    }
}
