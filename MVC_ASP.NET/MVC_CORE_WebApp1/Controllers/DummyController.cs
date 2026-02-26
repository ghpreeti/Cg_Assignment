using Microsoft.AspNetCore.Mvc;

namespace MVC_CORE_WebApp1.Controllers
{
    public class DummyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CallError()
        {
            throw new Exception("my custom Exception");
        }
    }
}
