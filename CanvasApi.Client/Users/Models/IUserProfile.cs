namespace CanvasApi.Client.Users.Models;

/// <summary>
/// Profile details for a Canvas user
/// </summary>
public interface IUserProfile
{
    /// <summary>
    /// The ID of the user
    /// </summary>
    long Id { get; }

    string Name { get; }

    string ShortName { get; }

    string SortableName { get; }

    string Title { get; }

    string Bio { get; }

    string PrimaryEmail { get; }

    string LoginId { get; }

    string SisUserId { get; }

    string LtiUserId { get; }

    /// <summary>
    /// The avatar_url can change over time, so we recommend not caching it for more than a few hours
    /// </summary>
    string AvatarUrl { get; }

    object Calendar { get; }

    /// <summary>
    /// Optional: This field is only returned in certain API calls, and will return the IANA time zone name of the user's preferred timezone.
    /// </summary>
    string TimeZone { get; }

    /// <summary>
    /// The users locale
    /// </summary>
    string Locale { get; }
}