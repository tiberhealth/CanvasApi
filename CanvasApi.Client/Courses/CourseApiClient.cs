using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.Courses.Models;
using CanvasApi.Client.Courses.Models.Concrete;

namespace CanvasApi.Client.Courses
{
    internal class CourseApiClient : ApiClientBase, ICourseApiClient
    {
        public CourseApiClient(CanvasApiClient parent) : base(parent) { }

        public async Task<IEnumerable<ICourse>> List(Action<IListOptions> optionsFactory)
        {
            var options = new ListOptions();
            optionsFactory?.Invoke(options);

            return await this.ApiClient.PagableApiOperation<Course, IListOptions>(HttpMethod.Get, "/api/v1/courses", options);
        }

        public async Task<IEnumerable<ICourse>> List(long userId, Action<IListOptionsBasic> optionsFactory)
        {
            var options = new ListOptionsBasic();
            optionsFactory?.Invoke(options);

            return await this.ApiClient.PagableApiOperation<Course, IListOptionsBasic>(HttpMethod.Get, $"/api/v1/users/{userId}/courses", options);
        }

        public Task<ICourseProgress> Progress(long courseId, long userId)
        {
            throw new NotImplementedException();
        }
    }
}
