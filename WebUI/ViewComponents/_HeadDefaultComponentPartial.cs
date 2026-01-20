using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class _HeadDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
