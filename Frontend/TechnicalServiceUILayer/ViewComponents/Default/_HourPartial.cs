using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceUILayer.ViewComponents.Default
{
    public class _HourPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
