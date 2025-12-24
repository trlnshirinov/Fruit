using Microsoft.AspNetCore.Mvc;

namespace MVCPractice2.ViewComponents
{
    public class FeatureSectionViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
