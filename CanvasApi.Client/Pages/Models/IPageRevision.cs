using System;
namespace CanvasApi.Client.Pages.Models
{
    public interface IPageRevision
    {
        /// <summary>
        /// an identifier for this revision of the page
        /// </summary>
        long RevisionId { get; }
        /// <summary>
        /// the time when this revision was saved
        /// </summary>
        DateTime? UpdatedAt { get; }
        /// <summary>
        /// whether this is the latest revision or not
        /// </summary>
        bool? Latest { get; }
        /// <summary>
        /// the User who saved this revision, if applicable (this may not be present if
        /// the page was imported from another system)
        /// </summary>
        string EditedBy { get; }
        /// <summary>
        /// the following fields are not included in the index action and may be omitted
        /// from the show action via summary=1 the historic url of the page
        /// </summary>
        string Url { get; }
        /// <summary>
        /// the historic page title
        /// </summary>
        string Title { get; }
        /// <summary>
        /// the historic page contents
        /// </summary>
        string Body { get; }
    }
}
