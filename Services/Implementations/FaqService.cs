using FinalProjectMVC.Identity.Data;
using FinalProjectMVC.Models;
using FinalProjectMVC.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectMVC.Services.Implementations
{
    public class FaqService : IfaqService
    {

        private readonly AppDbContext _context;

        public FaqService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<FAQ>> GetFAQSAsync()
        {
            return await _context.FAQS.ToListAsync();
        }
    }
}
