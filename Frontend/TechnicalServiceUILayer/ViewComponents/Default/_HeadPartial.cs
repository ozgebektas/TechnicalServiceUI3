using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceUILayer.ViewComponents.Default
{
    public class _HeadPartial  : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
