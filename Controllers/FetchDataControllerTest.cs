using Jerello.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Jerello.Tests
{
    [TestFixture]
    public class FetchDataControllerTests
    {
        [Test]
        public void Get_Returns_JsonData()
        {
            var controller = new FetchDataController();

            var result = controller.Get() as OkObjectResult;

            // Must be tested after deployment (See /apis/fetchdata will give you Error.cshtml page!)
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.IsInstanceOf(typeof(string), result.Value);
        }

        [Test]
        public void Get_Returns_Error_On_Failure()
        {
            var controller = new FetchDataController();

            var result = controller.Get() as StatusCodeResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
        }
    }
}