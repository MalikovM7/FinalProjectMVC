using FinalProjectMVC.Data;
using FinalProjectMVC.Models;
using FinalProjectMVC.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectMVC.Services.Implementations
{
    public class VehicleService : IVehicleService
    {
        private readonly AppDbContext _context;

        public VehicleService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Car>> GetVehiclesAsync()
        {
           return await _context.Cars.ToListAsync();
        }
    }
}
