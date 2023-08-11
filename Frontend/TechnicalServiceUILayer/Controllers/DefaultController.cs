using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceUILayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
