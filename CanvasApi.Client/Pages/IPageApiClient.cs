using IListOptions = CanvasApi.Client.Pages.Models.IListOptions;

namespace CanvasApi.Client.Pages;

public interface IPageApiClient
{
    /// <summary>
    /// Retrieve the content of the front page 
    /// </summary>
    /// <param name="id">Id of the course or group</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IPage> FrontPage(long id, CourseGroupFlag type = CourseGroupFlag.Course);

    /// <summary>
    /// Duplicate a wiki page
    /// </summary>
    /// <param name="id">Id of the course or group</param>
    /// <param name="url">Url of the page for the course or group</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IPage> Duplicate(long courseId, string url);

    /// <summary>
    /// Update the title or contents of the from page
    /// </summary>
    /// <param name="id">Id of the course or group</param>
    /// <param name="pageFactory">Factory to build the WIKI parameters to create/update the WIKI</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IPage> UpdateFontPage(long id, Action<IWikiPage> pageFactory, CourseGroupFlag type = CourseGroupFlag.Course);

    /// <summary>
    /// A paginated list of the wiki pages with a course
    /// </summary>
    /// <param name="id">Id of the course or group</param>
    /// <param name="optionsFactory">Factory to build filter and sorting options</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IEnumerable<IPage>> List(long id, Action<IListOptions> optionsFactory = null, CourseGroupFlag type = CourseGroupFlag.Course);


    /// <summary>
    /// Create a new wiki page 
    /// </summary>
    /// <param name="id">Id of the course or group</param>
    /// <param name="pageFactory">Factory to build the WIKI parameters to create/update the WIKI</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IPage> Create(long id, Action<IWikiPage> pageFactory, CourseGroupFlag type = CourseGroupFlag.Course);


    /// <summary>
    /// Retrieve the content of a wiki page 
    /// </summary>
    /// <param name="id">Id of the course or group</param> 
    /// <param name="url">Url of the page for the course or group</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IPage> Show(long id, string url, CourseGroupFlag type = CourseGroupFlag.Course);

    /// <summary>
    /// Update the title or contents of a wiki page
    /// </summary>
    /// <param name="id">Id of the course or group</param> 
    /// <param name="url">Url of the page for the course or group</param>
    /// <param name="pageFactory">Factory to build the WIKI parameters to create/update the WIKI</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IPage> UpdatePage(long Id, string url, Action<IWikiPage> pageFactory, CourseGroupFlag type = CourseGroupFlag.Course);

    /// <summary>
    /// Delete a wiki page
    /// </summary>
    /// <param name="id">Id of the course or group</param> 
    /// <param name="url">Url of the page for the course or group</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IPage> Delete(long id, string url, CourseGroupFlag type = CourseGroupFlag.Course);

    /// <summary>
    /// A paginated list of the revisions of a page. Callers must have update rights on the page in ourder to see page history
    /// </summary>
    /// <param name="id">Id of the course or group</param> 
    /// <param name="url">Url of the page for the course or group</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IEnumerable<IPageRevision>> ListRevisions(long id, string url, CourseGroupFlag type = CourseGroupFlag.Course);

    /// <summary>
    /// Retrieve the metadata and optionally content of a revision of the page. Note that retrieving historic versions of pages requires edit rights.
    /// </summary>
    /// <param name="id">Id of the course or group</param> 
    /// <param name="url">Url of the page for the course or group</param>
    /// <param name="revisionId">The revision id to pull, if null pull latest revision</param>
    /// <param name="summary">If set, exclude page content from results</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IPageRevision> ShowRevision(long id, string url, long? revisionId, bool? summary, CourseGroupFlag type = CourseGroupFlag.Course);

    /// <summary>
    /// Revert a page to a prior revision
    /// </summary>
    /// <param name="id">Id of the course or group</param>
    /// <param name="url">Url of the page for the course or group</param>
    /// <param name="revisionId">Revision id to revert the page to</param>
    /// <param name="type">Flag to indicate if the id is for a group or a course. (Default Course)</param>
    /// <returns></returns>
    Task<IPageRevision> Revert(long id, string url, long revisionId, CourseGroupFlag type = CourseGroupFlag.Course);
}