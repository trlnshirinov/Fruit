using Microsoft.EntityFrameworkCore;
using MVCPractice2.Data;
using MVCPractice2.Services.Interfaces;

namespace MVCPractice2.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }   
        public async Task<Dictionary<string, string>> GetAllSettingsAsync()
        {
            var settings = await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
            return settings;
        }
    }
}
