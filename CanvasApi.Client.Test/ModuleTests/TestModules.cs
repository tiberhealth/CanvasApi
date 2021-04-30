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
            // var requireSequentialProgress = false;
            // int[] prerequisiteModuleIds = { };
            // var itemsCount = 0;
            // var itemsUrl = "https://canvas.rolesvillesoftware.com/api/v1/modules/42/items";
            // IModuleItem[] items = null;
            // var publishFinalGrade = false;
            // var published = true;

            var module = await this.TestCreateModule(
                name
                );
        }

        public async Task<IModule> TestCreateModule(
            string name
            )
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            var module = await api.Modules.CreateModule(1, request =>
            {
                request.Name = name;
            });

            Assert.IsNotNull(module);
            Assert.AreEqual(name, module.Name);

            return module;
        }
    }
}
