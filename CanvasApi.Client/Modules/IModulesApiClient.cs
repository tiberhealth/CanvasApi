using CanvasApi.Client.Modules.Models;
using CanvasApi.Client.Modules.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CanvasApi.Client.Modules
{
    public interface IModulesApiClient
    {
        Task<IModule> CreateModule(long courseId, Action<IModuleDetail> module);
        Task<IModuleItem> CreateModuleItem(long courseId, long moduleId, Action<IModuleItemDetail> moduleItem);
        Task<IModule> DeleteModule(long courseId, long id);
        Task<IModuleItem> DeleteModuleItem(long courseId, long moduleId, long id);
        Task<IModuleItemSequence> GetModuleItemSequence(long courseId, Action<IModuleItemSequenceOptions> options);
        Task<IEnumerable<IModuleItem>> ListModuleItems(long courseId, long moduleId, Action<IModuleItemListOptions> options);
        Task<IEnumerable<IModule>> ListModules(long courseId, Action<IModuleListOptions> options);
        void MarkModuleItemDone(long courseId, long moduleId, long id);
        void MarkModuleItemRead(long courseId, long moduleId, long id);
        Task<IModule> RelockModule(long courseId, long id);
        Task<IModule> ShowModule(long courseId, long id, Action<IModuleShowOptions> options);
        Task<IModuleItem> ShowModuleItem(long courseId, long moduleId, long id, Action<IModuleItemShowOptions> options);
        Task<IModule> UpdateModule(long courseId, long id, Action<IModuleDetail> module);
        Task<IModuleItem> UpdateModuleItem(long courseId, long moduleId, long id, Action<IModuleItemDetail> moduleItem);
    }
}