using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Sport[] sports = new Sport[3];
            Sport football = new Sport();
            football.Name = "Football";
            football.Image = "footballcarouselimage.jpg";
            sports[0] = football;
            Sport rugby = new Sport();
            rugby.Name = "Rugby";
            rugby.Image = "rugbycarouselimage.jpg";
            sports[1] = rugby;
            Sport netball = new Sport();
            netball.Name = "Netball";
            netball.Image = "netballcarouselimage.jpg";
            sports[2] = netball;

            return View(sports);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}