namespace CanvasApi.Client.Modules.Models
{
    public interface IMasteryPathSelectOptions
    {
        /// <summary>
        /// Assignment set chosen, as specified in the mastery_paths portion of the context module item response
        /// </summary>
        long? AssignmentSetId { get; set; }
        /// <summary>
        ///  Which student the selection applies to.If not specified, current user is implied.
        /// </summary>
        long? StudentId { get; set; }
    }
}