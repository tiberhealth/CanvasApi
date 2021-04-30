using System;
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
            // var requireSequentialProgress = false;
            // int[] prerequisiteModuleIds = { };
            // var itemsCount = 0;
            // var itemsUrl = "https://canvas.rolesvillesoftware.com/api/v1/modules/42/items";
            // IModuleItem[] items = null;
            // var publishFinalGrade = false;
            // var published = true;

            var module = await this.TestCreateModule(
                courseId,
                name
                );

            await this.TestDeleteModule(courseId, module.Id);
        }

        public async Task<IModule> TestCreateModule(
            long courseId,
            string name
            )
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

        public async Task<IModule> TestDeleteModule(
            long courseId,
            long id
            )
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var module = await api.Modules.DeleteModule(courseId, id);

            Assert.IsNotNull(module);

            return module;
        }
    }
}
