using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceUILayer.ViewComponents.Default
{
    public class _HeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
