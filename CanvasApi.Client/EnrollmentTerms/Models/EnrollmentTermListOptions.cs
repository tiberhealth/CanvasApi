namespace CanvasApi.Client.EnrollmentTerms.Models;

internal class EnrollmentTermListOptions : IEnrollmentTermListOptions
{
    public IEnumerable<EnrollmentTermIncludes> Include { get; set; }
    public IEnumerable<EnrollmentTermListWorkflowState> WorkflowState { get; set; }
}