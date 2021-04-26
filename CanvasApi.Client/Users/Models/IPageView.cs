using System;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.Users.Models
{
    public interface IPageView
    {

        /// <summary>
        /// A UUID representing the page view.  This is also the unique request id
        /// </summary>
        string Id { get; }

        /// <summary>
        /// If the request is from an API request, the app that generated the access
        /// token
        /// </summary>
        string AppName { get; }

        /// <summary>
        /// The URL requested
        /// </summary>
        string Url { get; }

        /// <summary>
        /// The type of context for the request
        /// </summary>
        string ContextType { get; }

        /// <summary>
        /// The type of asset in the context for the request, if any
        /// </summary>
        string AssetType { get; }

        /// <summary>
        /// The rails controller that handled the request
        /// </summary>
        string Controller { get; }

        /// <summary>
        /// The rails action that handled the request
        /// </summary>
        string Action { get; }

        /// <summary>
        /// This field is deprecated, and will always be false
        /// </summary>
        string Contributed { get; }

        /// <summary>
        /// An approximation of how long the user spent on the page, in seconds
        /// </summary>
        string InteractionSeconds { get; }

        /// <summary>
        /// When the request was made
        /// </summary>
        DateTime? CreatedAt { get; }

        /// <summary>
        /// A flag indicating whether the request was user-initiated, or automatic (such
        /// as an AJAX call)
        /// </summary>
        bool? UserRequest { get; }

        /// <summary>
        /// How long the response took to render, in seconds
        /// </summary>
        decimal? RenderTime { get; }

        /// <summary>
        /// The user-agent of the browser or program that made the request
        /// </summary>
        string UserAgent { get; }

        /// <summary>
        /// True if the request counted as participating, such as submitting homework
        /// </summary>
        bool? Participated { get; }

        /// <summary>
        /// The HTTP method such as GET or POST
        /// </summary>
        string HttpMethod { get; }

        /// <summary>
        /// The origin IP address of the request
        /// </summary>
        string RemoteIp { get; }

        /// <summary>
        /// The page view links to define the relationships
        /// </summary>
        JObject Links { get; }
    }
}
