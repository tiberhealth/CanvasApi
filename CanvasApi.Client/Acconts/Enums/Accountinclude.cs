using System;
namespace CanvasApi.Client.Acconts.Enums
{
    public enum Accountinclude
    {
        /// <summary>
        /// the 'tool_consumer_instance_guid' that will be sent for this account on LTI launches
        /// </summary>
        lti_guid,

        /// <summary>
        /// returns info about the privacy policy and terms of use
        /// </summary>
        registration_settings,

        /// <summary>
        /// returns services and whether they are enabled (requires account management permissions)
        /// </summary>
        services
    }
}
