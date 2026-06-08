namespace CanvasApi.Client.Modules;

public interface IModulesApiClient
{
    /// <summary>
    /// A paginated list of the modules in a course
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    Task<IEnumerable<IModule>> ListModules(long courseId, Action<IModuleListOptions> options);

    /// <summary>
    /// Get information about a single module
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="id"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    Task<IModule> ShowModule(long courseId, long id, Action<IModuleShowOptions> options);

    /// <summary>
    /// Create and return a new module
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="module"></param>
    /// <returns></returns>
    Task<IModule> CreateModule(long courseId, Action<IModuleDetail> module);

    /// <summary>
    /// Update and return an existing module
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="id"></param>
    /// <param name="module"></param>
    /// <returns></returns>
    Task<IModule> UpdateModule(long courseId, long id, Action<IModuleDetail> module);

    /// <summary>
    /// Delete a module
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<IModule> DeleteModule(long courseId, long id);

    /// <summary>
    /// Resets module progressions to their default locked state and recalculates them based on the current requirements.
    /// 
    /// Adding progression requirements to an active course will not lock students out of modules they have already unlocked unless this action is called.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<IModule> RelockModule(long courseId, long id);

    /// <summary>
    /// A paginated list of the items in a module
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="moduleId"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    Task<IEnumerable<IModuleItem>> ListModuleItems(long courseId, long moduleId, Action<IModuleItemListOptions> options);

    /// <summary>
    /// Get information about a single module item
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="moduleId"></param>
    /// <param name="id"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    Task<IModuleItem> ShowModuleItem(long courseId, long moduleId, long id, Action<IModuleItemShowOptions> options);

    /// <summary>
    /// Create and return a new module item
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="moduleId"></param>
    /// <param name="moduleItem"></param>
    /// <returns></returns>
    Task<IModuleItem> CreateModuleItem(long courseId, long moduleId, Action<IModuleItemDetail> moduleItem);
        
    /// <summary>
    /// Update and return an existing module item
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="moduleId"></param>
    /// <param name="id"></param>
    /// <param name="moduleItem"></param>
    /// <returns></returns>
    Task<IModuleItem> UpdateModuleItem(long courseId, long moduleId, long id, Action<IModuleItemDetail> moduleItem);

    /// <summary>
    /// Select a mastery path when module item includes several possible paths. Requires Mastery Paths feature to be enabled. Returns a compound document with the assignments included in the given path and any module items related to those assignments
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="moduleId"></param>
    /// <param name="id"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    Task<JObject> SelectMasteryPath(long courseId, long moduleId, long id, Action<IMasteryPathSelectOptions> options);

    /// <summary>
    /// Delete a module item
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="moduleId"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<IModuleItem> DeleteModuleItem(long courseId, long moduleId, long id);

    /// <summary>
    /// Mark a module item as done/not done. Use HTTP method PUT to mark as done, and DELETE to mark as not done.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="moduleId"></param>
    /// <param name="id"></param>
    Task MarkModuleItemDone(long courseId, long moduleId, long id);

    /// <summary>
    /// Mark a module item as done/not done. Use HTTP method PUT to mark as done, and DELETE to mark as not done.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="moduleId"></param>
    /// <param name="id"></param>
    Task MarkModuleItemNotDone(long courseId, long moduleId, long id);

    /// <summary>
    /// Given an asset in a course, find the ModuleItem it belongs to, the previous and next Module Items in the course sequence, and also any applicable mastery path rules
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    [Obsolete("Unable to test, Canvas throwing error, need to research.")]
    Task<IModuleItemSequence> GetModuleItemSequence(long courseId, Action<IModuleItemSequenceOptions> options);

    /// <summary>
    /// Fulfills “must view” requirement for a module item. It is generally not necessary to do this explicitly, but it is provided for applications that need to access external content directly (bypassing the html_url redirect that normally allows Canvas to fulfill “must view” requirements).
    /// 
    /// This endpoint cannot be used to complete requirements on locked or unpublished module items.
    /// </summary>
    /// <param name="courseId"></param>
    /// <param name="moduleId"></param>
    /// <param name="id"></param>
    Task MarkModuleItemRead(long courseId, long moduleId, long id);

}