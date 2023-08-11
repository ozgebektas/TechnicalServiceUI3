using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceUILayer.ViewComponents.Default
{
    public class _GrandPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
