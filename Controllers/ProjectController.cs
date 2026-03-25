using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
