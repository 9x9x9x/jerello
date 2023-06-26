using jerello.Data;
using NUnit.Framework;

namespace Jerello.Tests
{
    [TestFixture]
    public class UserTasksServiceTests
    {
        [Test]
        public void Summaries_Array_Contains_Expected_Values()
        {
            var expectedSummaries = new[] { "ToDo", "In Progress", "Completed" };

            var actualSummaries = UserTasksService.Summaries;

            Assert.IsNotNull(actualSummaries);
            Assert.AreEqual(expectedSummaries.Length, actualSummaries.Length);

            for (int i = 0; i < expectedSummaries.Length; i++)
            {
                Assert.AreEqual(expectedSummaries[i], actualSummaries[i]);
            }
        }
    }
}