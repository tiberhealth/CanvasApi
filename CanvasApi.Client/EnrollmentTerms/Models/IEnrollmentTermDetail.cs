
namespace CanvasApi.Client.EnrollmentTerms.Models;

public interface IEnrollmentTermDetail: IEnrollmentDates
{
    /// <summary>
    /// The name of the term.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// The unique SIS identifier for the term.
    /// </summary>
    string SisTermId { get; set; }

    // TODO: Need to figure out how to do the overrides

}