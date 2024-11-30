using FinalProjectMVC.Models;

namespace FinalProjectMVC.Services.Interfaces
{
    public interface IAboutUsService
    {
        Task<List<AboutUsViewModel>> GetAboutUsContentAsync();
    }
}
