using System;
using System.Collections.Generic;
using CanvasApi.Client.Assignments.Enums;
using SubmissionTypes = CanvasApi.Client.Assignments.Enums.SubmissionTypes;

namespace CanvasApi.Client.Assignments.Models;

/// <summary>
/// Inner Assignment[...] body fields for assignment create/edit calls.
/// The Canvas API wraps these fields in an <c>assignment</c> parent
/// (e.g. <c>assignment[name]=Block Exam 4</c>); the wrapping is handled
/// by <see cref="IAssignmentCreate"/>.
/// Used by:
///     POST /api/v1/courses/:course_id/assignments
///     PUT  /api/v1/courses/:course_id/assignments/:id
/// </summary>
public interface IAssignmentNewEdit
{
    /// <summary>The assignment name.</summary>
    string Name { get; set; }

    /// <summary>The position of this assignment in the gradebook.</summary>
    int? Position { get; set; }

    /// <summary>
    /// Allowed submission types. For grade-only / score-entry assignments
    /// (the ExamSoft case) use [None] or [OnPaper].
    /// </summary>
    IEnumerable<SubmissionTypes> SubmissionTypes { get; set; }

    /// <summary>The maximum points possible for the assignment.</summary>
    decimal? PointsPossible { get; set; }

    /// <summary>Grading type: PassFail, Percent, LetterGrade, GpaScale, Points.</summary>
    GradingTypes? GradingType { get; set; }

    /// <summary>The id of the assignment group this assignment belongs to.</summary>
    long? AssignmentGroupId { get; set; }

    /// <summary>The due date for the assignment.</summary>
    DateTime? DueAt { get; set; }

    /// <summary>The lock date.</summary>
    DateTime? LockAt { get; set; }

    /// <summary>The unlock date.</summary>
    DateTime? UnlockAt { get; set; }

    /// <summary>HTML description.</summary>
    string Description { get; set; }

    /// <summary>Whether the assignment is published.</summary>
    bool? Published { get; set; }

    /// <summary>Whether to send a notification on update.</summary>
    bool? NotifyOfUpdate { get; set; }

    /// <summary>Whether the assignment is omitted from the final grade.</summary>
    bool? OmitFromFinalGrade { get; set; }
}
