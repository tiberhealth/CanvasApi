using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CanvasApi.Client.Test
{
    public class TestEnrollmentTerms: RolesvilleUniversityTest
    {
        [Test]
        public async Task TestEnrollmentTermsFull()
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            Assert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            Assert.IsNotNull(api);

            // Test Values
            var termName = $"Test Term {Guid.NewGuid()}";
            var startAt = DateTime.Now.Date.AddDays(-10);
            var endAt = startAt.AddDays(90);
            var sisTermId = Guid.NewGuid().ToString(); 

            // Create new Enrollment Term
            var termResponse = await api.EnrollmentTerms.Create(1, request =>
            {
                request.Name = termName;
                request.StartAt = startAt;
                request.EndAt = endAt;
                request.SisTermId = sisTermId;
            });

            await Task.CompletedTask;
        }
    }
}
