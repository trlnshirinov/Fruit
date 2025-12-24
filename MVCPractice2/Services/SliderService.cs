using Microsoft.EntityFrameworkCore;
using MVCPractice2.Data;
using MVCPractice2.Services.Interfaces;
using MVCPractice2.ViewModels.Slider;

namespace MVCPractice2.Services
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _context;
        public SliderService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SliderUIVM>> GetAllAsync()
        {
            var sliders = await _context.Sliders.Select(s => new SliderUIVM
            {
                Title = s.Title,
                Image = s.Image
            }).ToListAsync();

            return sliders;
        }
    }
}
