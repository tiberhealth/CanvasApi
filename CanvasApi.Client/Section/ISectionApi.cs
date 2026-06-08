namespace CanvasApi.Client.Section;

public interface ISectionApi
{
    /// <summary>
    /// A paginated list of the list of sections for this course.
    /// </summary>
    /// <param name="courseId">The Canvas ID for the course to get the section list for</param>
    /// <returns></returns>
    Task<IEnumerable<ICourseSection>> List(long courseId);

    /// <summary>
    /// Gets details about a specific section
    /// </summary>
    /// <param name="courseId">The Canvas ID for the course the section belongs</param>
    /// <param name="sectionId">The Canvas ID for the section</param>
    /// <returns></returns>
    Task<ICourseSection> Get(long courseId, long sectionId);
    /// <summary>
    /// Gets details about a specific section
    /// </summary>
    /// <param name="courseId">The Canvas ID for the course the section belongs</param>
    /// <param name="sectionId">The Canvas ID for the section</param>
    /// <returns></returns>
    Task<ICourseSection> Get(long sectionId);
}
