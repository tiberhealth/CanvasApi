using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IMasteryPathSelectOptions
    {
        /// <summary>
        /// Assignment set chosen, as specified in the mastery_paths portion of the context module item response
        /// </summary>
        [Multipart("assignment_set_id")] long? AssignmentSetId { get; set; }
        /// <summary>
        ///  Which student the selection applies to.If not specified, current user is implied.
        /// </summary>
        [Multipart("student_id")] long? StudentId { get; set; }
    }
}