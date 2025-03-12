namespace CanvasApi.Client.Users.Models;

/// This mini-object is returned in place of UserDisplay when returning student
/// data for anonymous assignments, and includes an anonymous ID to identify a
/// user within the scope of a single assignment.
public interface IAnonumousUserDisplay
{
    /// <summary>
    /// A unique short ID identifying this user within the scope of a particular
    /// assignment.
    /// </summary>
    string AnonymouusId { get; }

    /// <summary>
    /// A URL to retrieve a generic avatar.
    /// </summary>
    string AvatarImageUrl { get; }
}