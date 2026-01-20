using Microsoft.AspNetCore.Mvc;

namespace WebProject.ViewComponents
{
    public class _NavbarDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
