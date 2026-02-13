using Microsoft.AspNetCore.Mvc;

namespace QuickStart.WebUI.Controllers
{
    public class _AdminLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
