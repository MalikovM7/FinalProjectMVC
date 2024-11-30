using FinalProjectMVC.Models;
using FinalProjectMVC.Services.Interfaces;
using FinalProjectMVC.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FinalProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomePreviewService _homePreviewService;
        private readonly IAboutUsService _aboutUsService;

        public HomeController(ILogger<HomeController> logger, IHomePreviewService homePreviewService, IAboutUsService aboutUsService)
        {
            _logger = logger;
            _homePreviewService = homePreviewService;
            _aboutUsService = aboutUsService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var previews = await _homePreviewService.GetHomePreviewsAsync();
            var aboutUsContent = await _aboutUsService.GetAboutUsContentAsync();

            if (aboutUsContent == null)
            {
                _logger.LogWarning("No About Us content found in the database.");
            }

            var model = new HomePageViewModel
            {
                Previews = previews,
                AboutUs = aboutUsContent
            };

            return View(model);
        }
    }
}