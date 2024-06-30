using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class JobPositionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
