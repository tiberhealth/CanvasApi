namespace CanvasApi.Client.Users.Models;

/// <summary>
/// This mini-object is used for secondary user responses, when we just want to
/// provide enough information to display a user.    public interface IUserDisplay
/// </summary>
public interface IUserDisplay
{
    /// <summary>
    /// The ID of the user.
    /// </summary>
    public long Id { get; }

    /// <summary>
    /// A short name the user has selected, for use in conversations or other less
    /// formal places through the site.
    /// </summary>
    public string ShortName { get; }

    /// <summary>
    /// If avatars are enabled, this field will be included and contain a url to
    /// retrieve the user's avatar.
    /// </summary>
    public string AvatarImageUrl { get; }

    /// <summary>
    /// URL to access user, either nested to a context or directly.
    /// </summary>
    public string HtmlUrl { get; }
}