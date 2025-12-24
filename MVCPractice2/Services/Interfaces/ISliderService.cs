using MVCPractice2.ViewModels.Slider;

namespace MVCPractice2.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<SliderUIVM>> GetAllAsync();
    }
}
