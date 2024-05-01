using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CanvasApi.Client.Test.AssignmentGroupsTests;


public class TestAssignmentGroups : TestSetup
{
    [Test]
    public async Task AssignmentGroupListTest()
    {
        var services = this.ServiceCollection.BuildServiceProvider();
        var api = services.GetRequiredService<ICanvasApiClient>();

        var courses = await api.Courses.List();

        Assert.That(courses.Any());
    }
}
