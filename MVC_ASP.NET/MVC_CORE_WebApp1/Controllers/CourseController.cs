using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace MVC_CORE_WebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public IActionResult DoTask1()
        {
            var res = new
            {
                CourseId = 101,
                CourseName = "ASP.NET Core",
                Duration = "3",
                CourseFee = 5000

            };
            return Ok(res);

        }
    }
}
