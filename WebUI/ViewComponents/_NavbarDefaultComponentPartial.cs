using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class _NavbarDefaultComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
