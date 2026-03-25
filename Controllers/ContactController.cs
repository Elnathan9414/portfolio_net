using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
