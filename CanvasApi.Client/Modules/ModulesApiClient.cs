using CanvasApi.Client._Base;
using CanvasApi.Client.Extentions;
using CanvasApi.Client.Modules.Models;
using CanvasApi.Client.Modules.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CanvasApi.Client.Modules
{
    public class ModulesApiClient : ApiClientBase, IModulesApiClient
    {
        public ModulesApiClient(CanvasApiClient parent) : base(parent) { }

        public async Task<IEnumerable<IModule>> ListModules(long courseId, Action<IModuleListOptions> options) =>
            await this.ApiClient.PagableApiOperation<Module, IModuleListOptions>(
                HttpMethod.Get,
                $"/api/v1/courses/{courseId}/modules",
                options.GetOptions<IModuleListOptions, ModuleListOptions>()
                );

        public async Task<IModule> ShowModule(long courseId, long id, Action<IModuleShowOptions> options) =>
            await this.ApiClient.ApiOperation<Module, IModuleShowOptions>(
                HttpMethod.Get,
                $"/api/v1/courses/{courseId}/modules/{id}",
                options.GetOptions<IModuleShowOptions, ModuleShowOptions>()
                );

        public async Task<IModule> CreateModule(long courseId, Action<IModuleDetail> module) =>
            await this.ApiClient.ApiOperation<Module, IModuleCreateUpdateOptions>(
                HttpMethod.Put,
                $"/api/v1/courses/{courseId}/modules",
                (IModuleCreateUpdateOptions)new ModuleCreateUpdateOptions { Module = module.GetOptions<IModuleDetail, ModuleDetail>() }
                );

        public async Task<IModule> UpdateModule(long courseId, long id, Action<IModuleDetail> module) =>
            await this.ApiClient.ApiOperation<Module, IModuleCreateUpdateOptions>(
                HttpMethod.Post,
                $"/api/v1/courses/{courseId}/modules/{id}",
                new ModuleCreateUpdateOptions { Module = module.GetOptions<IModuleDetail, ModuleDetail>() }
                );

        public async Task<IModule> DeleteModule(long courseId, long id) =>
            await this.ApiClient.ApiOperation<Module>(
                HttpMethod.Delete,
                $"/api/v1/courses/{courseId}/modules/{id}"
                );

        public async Task<IModule> RelockModule(long courseId, long id) =>
            await this.ApiClient.ApiOperation<Module>(
                HttpMethod.Put,
                $"/api/v1/courses/{courseId}/modules/{id}/relock"
                );

        public async Task<IEnumerable<IModuleItem>> ListModuleItems(long courseId, long moduleId, Action<IModuleItemListOptions> options) =>
            await this.ApiClient.PagableApiOperation<ModuleItem, IModuleItemListOptions>(
                HttpMethod.Get,
                $"/api/v1/courses/{courseId}/modules/{moduleId}/items",
                options.GetOptions<IModuleItemListOptions, ModuleItemListOptions>()
                );

        public async Task<IModuleItem> ShowModuleItem(long courseId, long moduleId, long id, Action<IModuleItemShowOptions> options) =>
            await this.ApiClient.ApiOperation<ModuleItem, IModuleItemShowOptions>(
                HttpMethod.Get,
                $"/api/v1/courses/{courseId}/modules/{moduleId}/items/{id}",
                options.GetOptions<IModuleItemShowOptions, ModuleItemShowOptions>()
                );

        public async Task<IModuleItem> CreateModuleItem(long courseId, long moduleId, Action<IModuleItemDetail> moduleItem) =>
            await this.ApiClient.ApiOperation<ModuleItem, IModuleItemCreateUpdateOptions>(
                HttpMethod.Put,
                $"/api/v1/courses/{courseId}/modules/{moduleId}/items",
                (IModuleItemCreateUpdateOptions)new ModuleItemCreateUpdateOptions { ModuleItem = moduleItem.GetOptions<IModuleItemDetail, ModuleItemDetail>() }
                );

        public async Task<IModuleItem> UpdateModuleItem(long courseId, long moduleId, long id, Action<IModuleItemDetail> moduleItem) =>
            await this.ApiClient.ApiOperation<ModuleItem, IModuleItemCreateUpdateOptions>(
                HttpMethod.Post,
                $"/api/v1/courses/{courseId}/modules/{moduleId}/items/{id}",
                new ModuleItemCreateUpdateOptions { ModuleItem = moduleItem.GetOptions<IModuleItemDetail, ModuleItemDetail>() }
                );

        public async Task<IModuleItem> DeleteModuleItem(long courseId, long moduleId, long id) =>
            await this.ApiClient.ApiOperation<ModuleItem>(
                HttpMethod.Delete,
                $"/api/v1/courses/{courseId}/modules/{moduleId}/items/{id}"
                );

        public async void MarkModuleItemDone(long courseId, long moduleId, long id) =>
            await this.ApiClient.ApiOperation<ModuleItem>(
                HttpMethod.Put,
                $"/api/v1/courses/{courseId}/modules/{moduleId}/items/{id}/done"
                );

        public async Task<IModuleItemSequence> GetModuleItemSequence(long courseId, Action<IModuleItemSequenceOptions> options) =>
            await this.ApiClient.ApiOperation<ModuleItemSequence, IModuleItemSequenceOptions>(
                HttpMethod.Get,
                $"/api/v1/courses/{courseId}/module_item_sequence",
                options.GetOptions<IModuleItemSequenceOptions, ModuleItemSequenceOptions>()
                );

        public async void MarkModuleItemRead(long courseId, long moduleId, long id) =>
            await this.ApiClient.ApiOperation<ModuleItem>(
                HttpMethod.Post,
                $"/api/v1/courses/{courseId}/modules/{moduleId}/items/{id}/mark_read"
                );
    }
}
