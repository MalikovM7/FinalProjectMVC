using FinalProjectMVC.Models;
using FinalProjectMVC.Services.Implementations;
using FinalProjectMVC.Services.Interfaces;
using FinalProjectMVC.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FinalProjectMVC.Controllers
{
    //[Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomePreviewService _homePreviewService;
        private readonly IAboutUsService _aboutUsService;
        private readonly IfaqService _faqService;

        public HomeController(ILogger<HomeController> logger, IHomePreviewService homePreviewService, IAboutUsService aboutUsService, IfaqService faqService)
        {
            _logger = logger;
            _homePreviewService = homePreviewService;
            _aboutUsService = aboutUsService;
            _faqService = faqService;
        }

        public async Task<IActionResult> Index()
        {
            var previews = await _homePreviewService.GetPreviewsAsync();
            var aboutUsContent = await _aboutUsService.GetAboutUsContentAsync();
            var faqs = await _faqService.GetFAQSAsync();

            if (previews == null || !previews.Any())
            {
                _logger.LogWarning("No home preview content found in the database.");
            }

            if (aboutUsContent == null || !aboutUsContent.Any())
            {
                _logger.LogWarning("No About Us content found in the database.");
            }

            if (faqs == null || !faqs.Any())
            {
                _logger.LogWarning("No FAQS found in the database.");
            }

            var model = new HomePageViewModel
            {
                Previews = previews ?? Enumerable.Empty<HomePreview>(),
                AboutUs = aboutUsContent ?? Enumerable.Empty<AboutUsViewModel>(),
                FAQs = faqs ?? Enumerable.Empty<FAQ>()
            };

            return View(model);
        }
    }
}