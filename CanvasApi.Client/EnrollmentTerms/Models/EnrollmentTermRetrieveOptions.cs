namespace CanvasApi.Client.EnrollmentTerms.Models;

internal class EnrollmentTermRetrieveOptions : IEnrollmentTermRetrieveOptions
{
    public IEnumerable<EnrollmentTermIncludes> Include { get; set; }
}