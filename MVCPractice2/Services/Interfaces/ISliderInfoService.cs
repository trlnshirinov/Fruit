using MVCPractice2.ViewModels.Slider;

namespace MVCPractice2.Services.Interfaces
{
    public interface ISliderInfoService
    {
        Task<SliderInfoUIVM> GetAllAsync();
    }
}
