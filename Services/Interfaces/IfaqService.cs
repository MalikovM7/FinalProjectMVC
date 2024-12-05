using FinalProjectMVC.Models;

namespace FinalProjectMVC.Services.Interfaces
{
    public interface IfaqService
    {
        Task<List<FAQ>> GetFAQSAsync();
        Task<FAQ> GetFAQByIdAsync(int id);
        Task AddFAQAsync(FAQ faq);
        Task UpdateFAQAsync(int id, FAQ faq);
        Task DeleteFAQAsync(int id);


    }
}
