using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Accounts.Enums
{
    [EnumAsString]
    public enum Accountinclude
    {
        /// <summary>
        /// the 'tool_consumer_instance_guid' that will be sent for this account on LTI launches
        /// </summary>
        [EnumSerializedValue("lti_guid")] LtiGuid,

        /// <summary>
        /// returns info about the privacy policy and terms of use
        /// </summary>
        [EnumSerializedValue("registration_settings")] RegistrationSettings,

        /// <summary>
        /// returns services and whether they are enabled (requires account management permissions)
        /// </summary>
        [EnumSerializedValue("services")] Services
    }
}
