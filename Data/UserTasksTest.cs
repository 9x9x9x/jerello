using jerello.Data;
using NUnit.Framework;
using System;

// I usually follow the Arrange, Act, Assert paradigm for Unit testing
namespace Jerello.Tests
{
    [TestFixture]
    public class UserTasksTests
    {
        [Test]
        public void UserTasks_Properties_Set_Correctly()
        {
            string name = "Task 1";
            string description = "This is task 1";
            var date = new DateOnly(2023, 7, 1);
            string summary = "Task 1 summary";

            var task = new UserTasks
            {
                Name = name,
                Description = description,
                Date = date,
                Summary = summary
            };

            Assert.AreEqual(name, task.Name);
            Assert.AreEqual(description, task.Description);
            Assert.AreEqual(date, task.Date);
            Assert.AreEqual(summary, task.Summary);
        }
    }
}