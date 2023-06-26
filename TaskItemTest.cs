using NUnit.Framework;
using jerello;

namespace Jerello.Tests
{
    [TestFixture]
    public class TasksItemTests
    {
        [Test]
        public void Properties_Can_Be_Set_And_Retrieved()
        {
            var item = new TasksItem();

            item.Title = "Do the Code Reviews";
            item.Description = "10 Code Reviews and Possible Refactorings";
            item.Summary = "Spring Review Work";
            item.Deadline = "2023-07-02";
            item.IsDone = true;

            Assert.AreEqual("Do the Code Reviews", item.Title);
            Assert.AreEqual("10 Code Reviews and Possible Refactorings", item.Description);
            Assert.AreEqual("Spring Review Work", item.Summary);
            Assert.AreEqual("2023-07-02", item.Deadline);
            Assert.IsTrue(item.IsDone);
        }
    }
}