using FinalProjectMVC.Data;
using FinalProjectMVC.Models;
using FinalProjectMVC.Repositories.Interfaces;

namespace FinalProjectMVC.Repositories.Implementations
{
    public class HomePreviewRepository : BaseRepository<HomePreview>, IHomePreviewRepository
    {
        public HomePreviewRepository(AppDbContext context) : base(context)
        {
        }
    }
}
