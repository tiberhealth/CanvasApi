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

            ClassicAssert.IsNotNull(results);
            ClassicAssert.IsNotEmpty(results);

            var resultCount = results.Count();
            ClassicAssert.Greater(resultCount, 0);
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
            ClassicAssert.IsNotNull(results);

            var finalResults = results.ToArray();
            var result = finalResults.SingleOrDefault(field => field.CourseId == 33);
            
            ClassicAssert.IsNotEmpty(finalResults);
            
            

        }
    }
}
