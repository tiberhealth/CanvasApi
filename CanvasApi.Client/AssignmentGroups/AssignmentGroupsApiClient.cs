using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.AssignmentGroups.Models;

namespace CanvasApi.Client.AssignmentGroups
{
    public class AssignmentGroupsApiClient : ApiClientBase, IAssignmentGroupsApiClient
    {
        public AssignmentGroupsApiClient(CanvasApiClient parent) : base(parent) { }

        public async Task<IAssignmentGroup> Create(long courseId, IAssignmentGroupNewEdit assignmentGroup) =>
            await this.ApiClient.ApiOperation<AssignmentGroup, IAssignmentGroupNewEdit>(
                HttpMethod.Post,
                $"/api/v1/courses/{courseId}/assignment_groups",
                assignmentGroup
                );

        public async Task<IAssignmentGroup> Destroy(long courseId, long assignmentGroupId, IDeleteAssignmentGroup body) =>
            await this.ApiClient.ApiOperation<AssignmentGroup, IDeleteAssignmentGroup>(
                HttpMethod.Delete,
                $"/api/v1/courses/{courseId}/assignment_groups/{assignmentGroupId}",
                body
                );

        public async Task<IAssignmentGroup> Edit(long courseId, long assignmentGroupId, IAssignmentGroupNewEdit assignmentGroup) =>
            await this.ApiClient.ApiOperation<AssignmentGroup, IAssignmentGroupNewEdit>(
                HttpMethod.Put,
                $"/api/v1/courses/{courseId}/assignment_groups/{assignmentGroupId}",
                assignmentGroup
                );

        public async Task<IAssignmentGroup> Get(long courseId, long assignmentGroupId, IAssignmentGroupGetOptions options = null) =>
            await this.ApiClient.ApiOperation<AssignmentGroup, IAssignmentGroupGetOptions>(
                HttpMethod.Get,
                $"/api/v1/courses/{courseId}/assignment_groups/{assignmentGroupId}",
                options
                );

        public async Task<IEnumerable<IAssignmentGroup>> List(long courseId, IAssignmentGroupListOptions options = null) =>
            await this.ApiClient.PagableApiOperation<AssignmentGroup, IAssignmentGroupListOptions>(
                HttpMethod.Get,
                $"/api/v1/courses/{courseId}/assignment_groups",
                options
                );
    }
}

