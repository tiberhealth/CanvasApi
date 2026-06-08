namespace CanvasApi.Client.Courses.Models;

public interface ICourseProgress
{
    /// <summary>
    /// total number of requirements from all modules
    /// </summary>
    int? RequirementCount { get; }

    /// <summary>
    /// total number of requirements the user has completed from all modules
    /// </summary>
    int? RequirementCompletedCount { get; }

    /// <summary>
    /// url to next module item that has an unmet requirement. null if the user has
    /// completed the course or the current module does not require sequential
    /// progress
    /// </summary>
    string NextRequirementUrl { get; }

    /// <summary>
    /// date the course was completed. null if the course has not been completed by
    /// this user
    /// </summary>
    DateTime? CompletedAt { get; }
}