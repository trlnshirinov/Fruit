using Microsoft.AspNetCore.Mvc;
using MVCPractice2.Services.Interfaces;
using MVCPractice2.ViewModels.Slider;

namespace MVCPractice2.ViewComponents
{
    public class HeroViewComponent : ViewComponent
    {
        private readonly ISliderInfoService _sliderInfoService;
        private readonly ISliderService _sliderService;

        public HeroViewComponent(ISliderService sliderService, ISliderInfoService sliderInfoService)
        {
            _sliderService = sliderService;
            _sliderInfoService = sliderInfoService;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliderInfos = await _sliderInfoService.GetAllAsync();
            var sliders = await _sliderService.GetAllAsync();

            SliderVMVC model = new SliderVMVC()
            {
                SliderInfo = sliderInfos,
                Sliders = sliders
            };

            return View(model);
        }
    }

    public class SliderVMVC
    {
        public SliderInfoUIVM SliderInfo { get; set; }
        public IEnumerable<SliderUIVM> Sliders { get; set; }

    }
}
