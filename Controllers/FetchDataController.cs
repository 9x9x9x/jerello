// Simple API /apis/fetchdata that will expose userTasks JSON over HTTP(S)

using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Jerello.Controllers
{
    [ApiController]
    [Route("apis/fetchdata")]
    public class FetchDataController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "fetchdata.json");
                string jsonData = System.IO.File.ReadAllText(filePath);
                return Ok(jsonData);
            }
            catch
            {
                return StatusCode(500, "An error occurred while fetching the data.");
            }
        }
    }
}
