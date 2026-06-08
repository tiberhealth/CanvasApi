namespace CanvasApi.Client.Enrollments.Models;

public interface IGrade
{
    /// <summary>
    /// The URL to the Canvas web UI page for the user's grades, if this is a student
    /// enrollment.
    /// </summary>
    string HtmlUrl { get; }

    /// <summary>
    /// The user's current grade in the class. Only included if user has permissions
    /// to view this grade.
    /// </summary>
    string CurrentGrade { get; }

    /// <summary>
    /// The user's final grade for the class. Only included if user has permissions
    /// to view this grade.
    /// </summary>
    string FinalGrade { get; }

    /// <summary>
    /// The user's current score in the class. Only included if user has permissions
    /// to view this score.
    /// </summary>
    string CurrentScore { get; }

    /// <summary>
    /// The user's final score for the class. Only included if user has permissions
    /// to view this score.
    /// </summary>
    string FinalScore { get; }

    /// <summary>
    /// The total points the user has earned in the class. Only included if user has
    /// permissions to view this score and 'current_points' is passed in the
    /// request's 'include' parameter.
    /// </summary>
    decimal? CurrentPoints { get; }

    /// <summary>
    /// The user's current grade in the class including muted/unposted assignments.
    /// Only included if user has permissions to view this grade, typically teachers,
    /// TAs, and admins.
    /// </summary>
    string UnpostedCurrentGrade { get; }

    /// <summary>
    /// The user's final grade for the class including muted/unposted assignments.
    /// Only included if user has permissions to view this grade, typically teachers,
    /// TAs, and admins..
    /// </summary>
    string UnpostedFinalGrade { get; }

    /// <summary>
    /// The user's current score in the class including muted/unposted assignments.
    /// Only included if user has permissions to view this score, typically teachers,
    /// TAs, and admins..
    /// </summary>
    string UnpostedCurrentScore { get; }

    /// <summary>
    /// The user's final score for the class including muted/unposted assignments.
    /// Only included if user has permissions to view this score, typically teachers,
    /// TAs, and admins..
    /// </summary>
    string UnpostedFinalScore { get; }

    /// <summary>
    /// The total points the user has earned in the class, including muted/unposted
    /// assignments. Only included if user has permissions to view this score
    /// (typically teachers, TAs, and admins) and 'current_points' is passed in the
    /// request's 'include' parameter.
    /// </summary>
    decimal? UnpostedCurrentPoints { get; }
}