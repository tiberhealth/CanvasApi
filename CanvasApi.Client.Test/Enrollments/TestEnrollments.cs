using System;
using System.Linq;
using System.Threading.Tasks;
using CanvasApi.Client.Enrollments.Enums;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CanvasApi.Client.Test.Enrollments
{
    public class TestEnrollments: TestSetup
    {
        [Test]
        public async Task TestGetEnrollments()
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            var api = services.GetRequiredService<ICanvasApiClient>();

            var results = await api.Enrollments.CourseEnrollments(1795, options => {
                options.Type = new [] { EnrollmentTypes.Student };
            });

            Assert.IsNotNull(results);
            Assert.IsNotEmpty(results);

            var resultCount = results.Count();
            Assert.Greater(resultCount, 0);

        }
    }
}
