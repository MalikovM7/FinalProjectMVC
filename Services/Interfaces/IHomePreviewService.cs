using FinalProjectMVC.Models;

namespace FinalProjectMVC.Services.Interfaces
{
    public interface IHomePreviewService
    {
        Task<List<HomePreview>> GetHomePreviewsAsync();
    }
}
