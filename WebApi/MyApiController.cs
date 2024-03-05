using Microsoft.AspNetCore.Mvc;

//En webapi controller. Läs mer på https://learn.microsoft.com/en-us/aspnet/core/web-api

namespace WebApi
{
    [Route("api")]
    public class MyApiController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }

        [HttpGet("time")]
        public string GetTime()
        {
            return "Time on server: " + DateTime.Now.ToString("HH:mm:ss");
        }

        [HttpGet("json")]
        public object Json()
        {
            return new { Name = "John Doe", Age = 42, City = "Stockholm" };
        }
    }
}