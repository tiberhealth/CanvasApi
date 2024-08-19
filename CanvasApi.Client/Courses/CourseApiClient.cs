using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.Courses.Models;

namespace CanvasApi.Client.Courses
{
    internal class CourseApiClient(CanvasApiClient parent) : ApiClientBase(parent), ICourseApiClient
    {
        public async Task<IEnumerable<ICourse>> List(Action<IListOptions> optionsFactory = null)
        {
            var options = new ListOptions();
            optionsFactory?.Invoke(options);

            return await this.ApiClient.PagableApiOperation<Course, IListOptions>(HttpMethod.Get, "/api/v1/courses", options);
        }

        public async Task<IEnumerable<ICourse>> List(long userId, Action<IListOptionsBasic> optionsFactory = null)
        {
            var options = new ListOptionsBasic();
            optionsFactory?.Invoke(options);

            return await this.ApiClient.PagableApiOperation<Course, IListOptionsBasic>(HttpMethod.Get, $"/api/v1/users/{userId}/courses", options);
        }

        public Task<ICourseProgress> Progress(long courseId, long userId)
        {
            throw new NotImplementedException();
        }


        public async Task<ICourse> Get(long courseId) =>
            await this.ApiClient.ApiOperation<Course>(HttpMethod.Get, $"/api/v1/courses/{courseId}?include[]=sections"); 

    }
}
