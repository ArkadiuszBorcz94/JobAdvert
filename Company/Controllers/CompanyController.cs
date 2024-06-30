using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
