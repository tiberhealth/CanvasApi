using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Accounts.Enums
{
    [EnumAsString]
    public enum Accountinclude
    {
        /// <summary>
        /// the 'tool_consumer_instance_guid' that will be sent for this account on LTI launches
        /// </summary>
        LtiGuid,

        /// <summary>
        /// returns info about the privacy policy and terms of use
        /// </summary>
        RegistrationSettings,

        /// <summary>
        /// returns services and whether they are enabled (requires account management permissions)
        /// </summary>
        Services
    }
}
