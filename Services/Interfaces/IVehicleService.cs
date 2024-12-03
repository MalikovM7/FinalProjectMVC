using FinalProjectMVC.Models;

namespace FinalProjectMVC.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<List<Car>> GetVehiclesAsync();

    }
}
