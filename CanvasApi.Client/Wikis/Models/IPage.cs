using System;

namespace CanvasApi.Client.Wikis.Models;

public interface IPage
{
    /// <summary>
    /// the ID of the page
    /// </summary>
    long PageId { get; }

    /// <summary>
    /// the unique locator for the page
    /// </summary>
    string Url { get; }

    /// <summary>
    /// the title of the page
    /// </summary>
    string Title { get; }

    /// <summary>
    /// the creation date for the page
    /// </summary>
    DateTime? CreatedAt { get; }

    /// <summary>
    /// the date the page was last updated
    /// </summary>
    DateTime? UpdatedAt { get; }

    /// <summary>
    /// (DEPRECATED) whether this page is hidden from students (note: this is always
    /// reflected as the inverse of the published value)
    /// </summary>
    bool HideFromStudents { get; }

    /// <summary>
    /// roles allowed to edit the page; comma-separated list comprising a combination
    /// of 'teachers', 'students', 'members', and/or 'public' if not supplied, course
    /// defaults are used
    /// </summary>
    string EditingRoles { get; }

    /// <summary>
    /// the User who last edited the page (this may not be present if the page was
    /// imported from another system)
    /// </summary>
    string LastEditedBy { get; }

    /// <summary>
    /// the page content, in HTML (present when requesting a single page; optionally
    /// included when listing pages)
    /// </summary>
    string Body { get; }

    /// <summary>
    /// whether the page is published (true) or draft state (false).
    /// </summary>
    bool Published { get; }

    /// <summary>
    /// scheduled publication date for this page
    /// </summary>
    DateTime? PublishAt { get; }

    /// <summary>
    /// whether this page is the front page for the wiki
    /// </summary>
    bool FrontPage { get; }

    /// <summary>
    /// Whether or not this is locked for the user.
    /// </summary>
    bool LockedForUser { get; }

    /// <summary>
    /// (Optional) Information for the user about the lock. Present when
    /// locked_for_user is true.
    /// </summary>
    string LockInfo { get; }

    /// <summary>
    /// (Optional) An explanation of why this is locked for the user. Present when
    /// locked_for_user is true.
    /// </summary>
    string LockExplanation { get; }
}
