using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    //TODO: fix the infinte object. I don't know what these are supposed to be, but it ain't this
    public interface IEnrollmentOverrides
    {
        IEnrollmentOverrides Teacher { get; }
        IEnrollmentOverrides Student { get; }
        IEnrollmentOverrides TeachingAssistant { get; }
        IEnrollmentOverrides Designer { get; }
    }
}
