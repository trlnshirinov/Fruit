using Microsoft.AspNetCore.Mvc;

namespace MVCPractice2.ViewComponents
{
    public class FruitViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
