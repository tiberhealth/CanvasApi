namespace CanvasApi.Client.EnrollmentTerms.Models;

internal class EnrollmentTermsListResult
{
    public IEnumerable<EnrollmentTerm> EnrollmentTerms { get; set; }

    public static IEnumerable<EnrollmentTerm> ToArray(EnrollmentTermsListResult apiResult) => apiResult.EnrollmentTerms.ToArray();
}