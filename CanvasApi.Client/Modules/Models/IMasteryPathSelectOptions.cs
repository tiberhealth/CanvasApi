using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IMasteryPathSelectOptions
    {
        [Multipart("assignment_set_id")] long? AssignmentSetId { get; set; }
        [Multipart("student_id")] long? StudentId { get; set; }
    }
}