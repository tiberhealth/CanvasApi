using System;
using System.Collections.Generic;
using CanvasApi.Client.Enrollments.Models;

namespace CanvasApi.Client.Users.Models
{
    public interface IUser
    {
        /// <summary>
        /// The ID of the user.
        /// </summary>
        long Id { get; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The name of the user that is should be used for sorting groups of users, such
        /// as in the gradebook.
        /// </summary>
        string SortableName { get; }

        /// <summary>
        /// A short name the user has selected, for use in conversations or other less
        /// formal places through the site.
        /// </summary>
        string ShortName { get; }

        /// <summary>
        /// The SIS ID associated with the user.  This field is only included if the user
        /// came from a SIS import and has permissions to view SIS information.
        /// </summary>
        string SisUserId { get; }

        /// <summary>
        /// The id of the SIS import.  This field is only included if the user came from
        /// a SIS import and has permissions to manage SIS information.
        /// </summary>
        long? SisImportId { get; }

        /// <summary>
        /// The integration_id associated with the user.  This field is only included if
        /// the user came from a SIS import and has permissions to view SIS information.
        /// </summary>
        string IntegrationId { get; }

        /// <summary>
        /// The unique login id for the user.  This is what the user uses to log in to
        /// Canvas.
        /// </summary>
        string LoginId { get; }

        /// <summary>
        /// If avatars are enabled, this field will be included and contain a url to
        /// retrieve the user's avatar.
        /// </summary>
        string AvatarUrl { get; }

        /// <summary>
        /// Optional: This field can be requested with certain API calls, and will return
        /// a list of the users active enrollments. See the List enrollments API for more
        /// details about the format of these records.
        /// </summary>
        IEnumerable<IEnrollment> Enrollments { get; }

        /// <summary>
        /// Optional: This field can be requested with certain API calls, and will return
        /// the users primary email address.
        /// </summary>
        string Email { get; }

        /// <summary>
        /// Optional: This field can be requested with certain API calls, and will return
        /// the users locale in RFC 5646 format.
        /// </summary>
        string Locale { get; }

        /// <summary>
        /// Optional: This field is only returned in certain API calls, and will return a
        /// timestamp representing the last time the user logged in to canvas.
        /// </summary>
        DateTime? LastLogin { get; }

        /// <summary>
        /// Optional: This field is only returned in certain API calls, and will return
        /// the IANA time zone name of the user's preferred timezone.
        /// </summary>
        string TimeZone { get; }

        /// <summary>
        /// Optional: The user's bio.
        /// </summary>
        string Bio { get; }
    }
}