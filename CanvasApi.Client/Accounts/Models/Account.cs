using Newtonsoft.Json;

namespace CanvasApi.Client.Accounts.Models
{
    public class Account: IAccount
    {
        /// <summary>
        /// the ID of the Account object
        /// /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The display name of the account
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The UUID of the account
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// The account's parent ID, or null if this is the root account
        /// </summary>
        public long? ParentAccountId { get; set; }

        /// <summary>
        /// The storage quota for the account in megabytes, if not otherwise specified
        /// </summary>
        public int? DefaultStorageQuotaMb { get; set; }

        /// <summary>
        /// The storage quota for a user in the account in megabytes, if not otherwise specified
        /// </summary>
        public int? DefaultUserStorageQuoateMb { get; set; }

        /// <summary>
        /// The storage quota for a group in the account in megabytes, if not otherwise specified
        /// </summary>
        public int? DefaultGroupStorageQuoteMb { get; set; }

        /// <summary>
        /// The default time zone of the account. Allowed time zones are
        /// {http://www.iana.org/time-zones IANA time zones} or friendlier
        /// {http://api.rubyonrails.org/classes/ActiveSupport/TimeZone.html Ruby on Rails
        /// time zones}.
        /// </summary>
        public string DefaultTimeZone { get; set; }

        /// <summary>
        /// The account's identifier in the Student Information System. Only included if
        /// the user has permission to view SIS information.
        /// </summary>
        public string SisAccountId { get; set; }

        /// <summary>
        /// The account's identifier in the Student Information System. Only included if
        /// the user has permission to view SIS information.
        /// </summary>
        public string IntegrationId { get; set; }

        /// <summary>
        /// The id of the SIS import if created through SIS. Only included if the user
        /// has permission to manage SIS information.
        /// </summary>
        public long? SisImportId { get; set; }

        /// <summary>
        /// The account's identifier that is sent as context_id in LTI launches.
        /// </summary>
        public string LtiGuid { get; set; }

        /// <summary>
        /// The state of the account. Can be 'active' or 'deleted'.
        /// </summary>
        public string WorkflowState { get; set; }
    }
}
