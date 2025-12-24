using Microsoft.AspNetCore.Mvc;

namespace MVCPractice2.ViewComponents
{
    public class VesitableViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
