using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class RecordingController : Controller
    {
        public IActionResult Index(string sport)
        {
            Sport activeSport = new Sport();
            activeSport.Name = sport;

            return View(activeSport);
        }
    }
}
