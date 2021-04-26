namespace CanvasApi.Client.Assignments.Models
{
    public interface IExternalToolTagAttribute
    {
        /// <summary>
        /// URL to the external tool
        /// </summary>
        string Url { get; }

        /// <summary>
        /// Whether or not there is a new tab for the external tool
        /// </summary>
        bool? NewTab { get; }

        /// <summary>
        /// the identifier for this tool_tag
        /// </summary>
        string ResourceLinkId { get; }
    }
}
