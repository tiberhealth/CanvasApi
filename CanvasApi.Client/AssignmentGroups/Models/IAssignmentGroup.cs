using System;
using System.Collections.Generic;
using CanvasApi.Client.Assignments.Models;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.AssignmentGroups.Models
{
    public interface IAssignmentGroup
    {
        /// <summary>
        /// the id of the Assignment Group
        /// </summary>
        long Id { get; }
        /// <summary>
        /// the name of the Assignment Group
        /// </summary>
        string Name { get; }
        /// <summary>
        /// the position of the Assignment Group
        /// </summary>
        int? Position { get; }
        /// <summary>
        /// the weight of the Assignment Group
        /// </summary>
        decimal? GroupWeight { get; }
        /// <summary>
        /// the sis source id of the Assignment Group
        /// </summary>
        string SisSourceId { get; }
        /// <summary>
        /// the integration data of the Assignment Group
        /// </summary>
        JObject IntegrationData { get; }
        /// <summary>
        /// the assignments in this Assignment Group (see the Assignment API for a
        /// detailed list of fields)
        /// </summary>
        IEnumerable<IAssignment> Assignments { get; }
        /// <summary>
        /// the grading rules that this Assignment Group has
        /// </summary>
        IGradingRules Rules { get; }

    }
}
