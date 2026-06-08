namespace CanvasApi.Client.EnrollmentTerms.Models;

internal class EnrollmentTerm : EnrollmentDates, IEnrollmentTerm
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string SisTermId { get; set; }
    public long? SisImportId { get; set; }
        
    public EnrollmentOverrides Overrides { get; set; }
    IEnrollmentOverrides IEnrollmentTerm.Overrides => this.Overrides;
}