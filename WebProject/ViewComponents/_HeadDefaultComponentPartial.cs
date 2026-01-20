using Microsoft.AspNetCore.Mvc;

namespace WebProject.ViewComponents
{
    public class _HeadDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
