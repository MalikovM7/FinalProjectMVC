using FinalProjectMVC.Areas.Identity.Data;
using FinalProjectMVC.Models;
using FinalProjectMVC.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectMVC.Services.Implementations
{
    public class HomePreviewService : IHomePreviewService
    {
        private readonly AppDbContext _context;

        public HomePreviewService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<HomePreview>> GetHomePreviewsAsync()
        {
            return await _context.HomePreviews.ToListAsync(); // Use ToListAsync for async query
        }
    }
}
