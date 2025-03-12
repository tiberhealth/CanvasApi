namespace CanvasApi.Client.EnrollmentTerms.Models;

internal class EnrollmentTermNewUpdate : IEnrollmentTermNewUpdate
{
    IEnrollmentTermDetail IEnrollmentTermNewUpdate.EnrollmentTerm => EnrollmentTerm;

    internal IEnrollmentTermDetail EnrollmentTerm { get; init; }
}