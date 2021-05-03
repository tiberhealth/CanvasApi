using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CanvasApi.Client.EnrollmentTerms.Models;
using CanvasApi.Client.Modules.Enums;
using CanvasApi.Client.Modules.Models;
using CanvasApi.Client.Modules.Models.Concretes;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CanvasApi.Client.Test.ModuleTests
{
    public class TestModules : TestSetup
    {
        [Test]
        public async Task TestModulesFull()
        {
            // var id = 42;
            // var state = ModuleWorkflowState.MustView;
            // var position = 1;
            var name = "Testing Module";
            int courseId = 1;
            var title = "Module Item";
            // var requireSequentialProgress = false;
            // int[] prerequisiteModuleIds = { };
            // var itemsCount = 0;
            // var itemsUrl = "https://canvas.rolesvillesoftware.com/api/v1/modules/42/items";
            // IModuleItem[] items = null;
            // var publishFinalGrade = false;
            // var published = true;

            var module = await this.TestCreateModule(courseId, name);

            await this.TestListModules(courseId, module);
            module = await this.TestUpdateModule(courseId, module.Id);
            await this.TestShowModule(courseId, module);
            var moduleItem = await this.TestCreateModuleItem(courseId, module.Id, title);
            moduleItem = await this.TestUpdateModuleItem(courseId, module.Id, moduleItem.Id);
            await this.TestListModuleItems(courseId, module.Id, moduleItem);
            await this.TestDeleteModuleItem(courseId, module.Id, moduleItem.Id);
            await this.TestDeleteModule(courseId, module.Id);
        }

        private async Task<IEnumerable<IModule>> TestListModules(int courseId, IModule module)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var moduleList = await api.Modules.ListModules(courseId, request => { });

            Assert.IsNotNull(moduleList);

            var enumerator = moduleList.GetEnumerator();
            while (enumerator.MoveNext()) {
                if (enumerator.Current.Id == module.Id)
                {
                    break;
                }
            }
            Assert.AreEqual(enumerator.Current.Name, module.Name);
            return moduleList;
        }

        public async Task<IModule> TestCreateModule(long courseId, string name)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var module = await api.Modules.CreateModule(courseId, request =>
            {
                request.Name = name;
            });

            Assert.IsNotNull(module);
            Assert.AreEqual(name, module.Name);

            return module;
        }

        public async Task<IModule> TestUpdateModule(long courseId, long id)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var module = await api.Modules.UpdateModule(courseId, id, request =>
            {
                request.Name = "New Module Name";
            });

            Assert.IsNotNull(module);
            Assert.AreEqual("New Module Name", module.Name);

            return module;
        }

        public async Task<IModule> TestDeleteModule(long courseId, long id)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var module = await api.Modules.DeleteModule(courseId, id);

            Assert.IsNotNull(module);

            return module;
        }

        public async Task<IModule> TestShowModule(long courseId, IModule module)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var newModule = await api.Modules.ShowModule(courseId, module.Id, request => { });

            Assert.IsNotNull(newModule);
            Assert.AreEqual(newModule.Name, module.Name);
            return newModule;
        }

        private async Task<IEnumerable<IModuleItem>> TestListModuleItems(int courseId, long moduleId, IModuleItem moduleItem)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var moduleItemList = await api.Modules.ListModuleItems(courseId, moduleId, request => { });

            Assert.IsNotNull(moduleItemList);

            var enumerator = moduleItemList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current.Id == moduleItem.Id)
                {
                    break;
                }
            }

            Assert.AreEqual(enumerator.Current.Title, moduleItem.Title);
            return moduleItemList;
        }

        public async Task<IModuleItem> TestCreateModuleItem(long courseId, long moduleId, string title)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var moduleItem = await api.Modules.CreateModuleItem(courseId, moduleId, request =>
            {
                request.Title = title;
                request.Type = ModuleItemTypes.SubHeader;
            });

            Assert.IsNotNull(moduleItem);
            Assert.AreEqual(title, moduleItem.Title);

            return moduleItem;
        }

        public async Task<IModuleItem> TestUpdateModuleItem(long courseId, long moduleId, long id)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var moduleItem = await api.Modules.UpdateModuleItem(courseId, moduleId, id, request =>
            {
                request.Title = "New Title";
                request.Type = ModuleItemTypes.SubHeader;
            });

            Assert.IsNotNull(moduleItem);
            Assert.AreEqual("New Title", moduleItem.Title);

            return moduleItem;
        }

        public async Task<IModuleItem> TestDeleteModuleItem(long courseId, long moduleId, long id)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var moduleItem = await api.Modules.DeleteModuleItem(courseId, moduleId, id);

            Assert.IsNotNull(moduleItem);

            return moduleItem;
        }
    }
}
