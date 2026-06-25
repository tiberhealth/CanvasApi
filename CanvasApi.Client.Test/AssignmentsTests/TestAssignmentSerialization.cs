using System.Net.Http;
using CanvasApi.Client.Assignments.Models;
using TiberHealth.Serializer;

namespace CanvasApi.Client.Test.AssignmentsTests;

/// <summary>
/// Pure serialization tests for the assignment create/edit body. No live Canvas
/// API — just asserts the multipart form fields are named the way Canvas expects.
/// (AssignmentCreate / AssignmentNewEdit are internal; visible here via
/// InternalsVisibleTo("CanvasApi.Client.Test").)
/// </summary>
public class TestAssignmentSerialization
{
    private static HttpContent SerializeBody(IAssignmentCreate body) =>
        FormDataSerializer.Serialize(body, options =>
        {
            options.DefaultNameResolver = new PascalToSnakeResolver();
            options.EnumNameResolver = new PascalToSnakeResolver();
            options.DefaultDateFormat = "yyyy-MM-dd HH:mm:sszzz";
        });

    [Test]
    public async Task PostManually_serializes_as_assignment_post_manually()
    {
        var body = new AssignmentCreate
        {
            Assignment = new AssignmentNewEdit { Name = "Exam 1", PostManually = true }
        };

        var text = await SerializeBody(body).ReadAsStringAsync();

        // Field is wrapped in the canonical assignment[...] prefix and snake_cased.
        Assert.That(text, Does.Contain("assignment[post_manually]"));
        // The boolean value is present.
        Assert.That(text, Does.Contain("true"));
    }

    [Test]
    public async Task Existing_fields_still_snake_case_under_assignment_prefix()
    {
        // Guards the convention the PostManually addition relies on.
        var body = new AssignmentCreate
        {
            Assignment = new AssignmentNewEdit { Name = "Exam 1", PointsPossible = 100m }
        };

        var text = await SerializeBody(body).ReadAsStringAsync();

        Assert.That(text, Does.Contain("assignment[name]"));
        Assert.That(text, Does.Contain("assignment[points_possible]"));
    }
}
