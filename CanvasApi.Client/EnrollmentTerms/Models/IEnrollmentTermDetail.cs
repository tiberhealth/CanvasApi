
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentTermDetail: IEnrollmentDates
    {
        /// <summary>
        /// The name of the term.
        /// </summary>
        [Multipart("name")] string Name { get; set; }

        /// <summary>
        /// The unique SIS identifier for the term.
        /// </summary>
        [Multipart("sis_term_id")] string SisTermId { get; set; }

        // TODO: Need to figure out how to do the overrides

    }
}
