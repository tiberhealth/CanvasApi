using System.Collections.Generic;
using CanvasApi.Client.EnrollmentTerms.Enums;

namespace CanvasApi.Client.EnrollmentTerms
{
    public interface IEnrollmentTermListOptions
    {
        /// <summary>
        /// Array of additional information to include.and “submission” options are included. The “assignment_visibility” option additionally requires that the Differentiated Assignments course feature be turned on. If “observed_users” is passed along with “assignments” and “submission”, submissions for observed users will also be included as an array.
        ///
        /// Allowed values: <see cref="EnrollmentTermIncludes"/>
        /// overrides
        /// </summary>
        IEnumerable<EnrollmentTermIncludes> Include { get; set; }

        /// <summary>
        /// If set, only returns terms that are in the given state. Defaults to 'active'.
        ///
        /// Allowed values: <see cref="EnrollmentTermListWorkflowState"/>
        /// overrides
        /// </summary>
        IEnumerable<EnrollmentTermListWorkflowState> WorkflowState { get; set; }
    }
}