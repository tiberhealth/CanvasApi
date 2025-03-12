using SubmissionTypes = CanvasApi.Client.Submissions.Enums.SubmissionTypes;

namespace CanvasApi.Client.Submissions.Models;

public interface ISubmissionSubmitDetail
{
    /// <summary>
    /// The type of submission being made. The assignment submission_types must include this submission type as an allowed option, or the submission will be rejected with a 400 error.
    /// The submission_type given determines which of the following parameters is used.For instance, to submit a URL, submission[submission_type] must be set to “online_url”, otherwise the submission[url] parameter will be ignored.
    ///
    /// Allowed values:
    /// online_text_entry, online_url, online_upload, media_recording, basic_lti_launch
    /// </summary>
    SubmissionTypes SubmissionType { get; set; }

    /// <summary>
    /// Submit the assignment as an HTML document snippet. Note this HTML snippet will be sanitized using the same ruleset as a submission made from the Canvas web UI. The sanitized HTML will be returned in the response as the submission body. Requires a submission_type of “online_text_entry”.
    /// </summary>
    string Body { get; set; }

    /// <summary>
    /// Submit the assignment as a URL. The URL scheme must be “http” or “https”, no “ftp” or other URL schemes are allowed. If no scheme is given (e.g. “www.example.com”) then “http” will be assumed. Requires a submission_type of “online_url” or “basic_lti_launch”.
    /// </summary>
    string Url { get; set; }

    /// <summary>
    /// Submit the assignment as a set of one or more previously uploaded files residing in the submitting user's files section (or the group's files section, for group assignments).
    /// 
    /// To upload a new file to submit, see the submissions Upload a file API.
    ///
    /// Requires a submission_type of “online_upload”.
    /// </summary>
    IEnumerable<long> FileIds { get; set; }

    /// <summary>
    /// The media comment id to submit. Media comment ids can be submitted via this API, however, note that there is not yet an API to generate or list existing media comments, so this functionality is currently of limited use.
    ///
    /// Requires a submission_type of “media_recording”.
    /// </summary>
    string MediaCommentId { get; set; }

    /// <summary>
    /// The type of media comment being submitted.
    ///
    /// Allowed values:
    /// audio, video
    /// </summary>
    MediaCommentTypes? MediaCommentType { get; set; }

    /// <summary>
    /// Submit on behalf of the given user. Requires grading permission
    /// </summary>
    long? UserId { get; set; }

    /// <summary>
    /// Choose the time the submission is listed as submitted at. Requires grading permission.
    /// </summary>
    DateTime? SubmittedAt { get; set; }
}