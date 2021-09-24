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

            var results = await api.Enrollments.CourseEnrollments(1, options => {
                options.Type = new [] { EnrollmentTypes.Student };
                options.Include = new[] { EnrollmentInclude.CurrentPoints };
            });

            Assert.IsNotNull(results);
            Assert.IsNotEmpty(results);

            var resultCount = results.Count();
            Assert.Greater(resultCount, 0);
        }

        [Test]
        public async Task TestStudentEnrollment()
        {

            var services = this.ServiceCollection.BuildServiceProvider();
            var api = services.GetRequiredService<ICanvasApiClient>();

            var results = await api.Enrollments.UserEnrollments(428, options =>
            {
//                options.Type = new [] { EnrollmentTypes.Student };
                options.Include = new[] { EnrollmentInclude.CurrentPoints };
            });
            Assert.IsNotNull(results);

            var finalResults = results.ToArray();
            var result = finalResults.SingleOrDefault(field => field.CourseId == 33);
            
            Assert.IsNotEmpty(finalResults);
            
            

        }
    }
}
