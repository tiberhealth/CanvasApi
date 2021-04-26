using System;
namespace CanvasApi.Client.Users.Models
{
    public interface IAvatar
    {
        /// <summary>
        /// ['gravatar'|'attachment'|'no_pic'] The type of avatar record, for
        /// categorization purposes.
        /// </summary>
        string Type { get; }

        /// <summary>
        /// The url of the avatar
        /// </summary>
        string Url { get; }

        /// <summary>
        /// A unique representation of the avatar record which can be used to set the
        /// avatar with the user update endpoint. Note: this is an internal
        /// representation and is subject to change without notice. It should be consumed
        /// with this api endpoint and used in the user update endpoint, and should not
        /// be constructed by the client.
        /// </summary>
        string Token { get; }

        /// <summary>
        /// A textual description of the avatar record.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// ['attachment' type only] the internal id of the attachment
        /// </summary>
        long Id { get; }

        /// <summary>
        /// ['attachment' type only] the content-type of the attachment.
        /// </summary>
        string ContentType { get; }

        /// <summary>
        /// ['attachment' type only] the filename of the attachment
        /// </summary>
        string Filename { get; }

        /// <summary>
        /// ['attachment' type only] the size of the attachment
        /// </summary>
        long Size { get; }
    }
}
