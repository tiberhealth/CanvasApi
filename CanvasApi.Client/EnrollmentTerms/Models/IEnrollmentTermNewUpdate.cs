using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentTermNewUpdate
    {
        /// <summary>
        /// Enrollment Term Details
        /// </summary>
        IEnrollmentTermDetail EnrollmentTerm { get; }
    }
}
