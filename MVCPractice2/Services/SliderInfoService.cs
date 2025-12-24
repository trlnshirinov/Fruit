using Microsoft.EntityFrameworkCore;
using MVCPractice2.Data;
using MVCPractice2.Services.Interfaces;
using MVCPractice2.ViewModels.Slider;

namespace MVCPractice2.Services
{
    public class SliderInfoService : ISliderInfoService
    {
        private readonly AppDbContext _context;
        public SliderInfoService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<SliderInfoUIVM> GetAllAsync()
        {
            var sliderInfo = await _context.SliderInfos.Select(s => new SliderInfoUIVM
            {
                Title = s.Title,
                Description = s.Description
            }).FirstOrDefaultAsync();

            return sliderInfo;
        }
    }
}
