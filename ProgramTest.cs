using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using NUnit.Framework;

namespace Jerello.Tests
{
    [TestFixture]
    public class UserTasksTest // Future work: Extend it to : WebApplicationFactory<Startup> from Asp.Net.Mvc.Testing
    {
        [Test]
        public async Task UserTasksComponent_Renders_Correctly()
        {
            // // Possible Future Assertions:
            // Assert.That(content, Does.Contain("User Tasks"));
            // Assert.That(content, Does.Contain("Name"));
            // Assert.That(content, Does.Contain("Description"));
            // Assert.That(content, Does.Contain("Deadline"));
            // Assert.That(content, Does.Contain("Summary"));
        }

        [Test]
        public async Task AddNewTaskButton_Adds_New_Task()
        {
            // Future Test Cases
        }

        private int GetTaskCountFromContent(string content)
        {
            // Parse the HTML content to get the task count, example
            var countString = content.Split("Total Tasks: ")[1].Split("<")[0];
            return int.Parse(countString);
        }
    }
}