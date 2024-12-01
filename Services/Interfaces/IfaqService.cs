using FinalProjectMVC.Models;

namespace FinalProjectMVC.Services.Interfaces
{
    public interface IfaqService
    {
        Task<List<FAQ>> GetFAQSAsync();
    }
}
