using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceUILayer.ViewComponents.Default
{
    public class _ServicesClassPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
