using Microsoft.AspNetCore.Mvc;
using MVCPractice2.Services.Interfaces;

namespace MVCPractice2.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ILayoutService _layoutService;
        public HeaderViewComponent(ILayoutService layoutService)
        {
            _layoutService = layoutService; 
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var settings = await _layoutService.GetAllSettingsAsync();
            return View(settings);
        }
    }
}
