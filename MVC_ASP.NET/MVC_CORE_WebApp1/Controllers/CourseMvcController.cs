using Microsoft.AspNetCore.Mvc;

namespace MVC_CORE_WebApp1.Controllers
{
    public class CourseMvcController : Controller
    {
        public IActionResult Index()
        {
            var res = new
            {
                CourseId = 101,
                CourseName = "ASP.NET Core",
                Duration = "3",
                CourseFee = 5000

            };
            return Json(res);
           
        }
    }
}
