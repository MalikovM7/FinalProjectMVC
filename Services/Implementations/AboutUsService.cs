using FinalProjectMVC.Areas.Identity.Data;
using FinalProjectMVC.Models;
using FinalProjectMVC.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectMVC.Services.Implementations
{
    public class AboutUsService : IAboutUsService
    {
        private readonly AppDbContext _context;

        public AboutUsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<AboutUsViewModel>> GetAboutUsContentAsync()
        {
            return await _context.AboutUsViewModels.ToListAsync();
      
        }
    }
    }
