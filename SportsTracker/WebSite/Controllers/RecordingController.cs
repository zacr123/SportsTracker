using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class RecordingController : Controller
    {
        public IActionResult Index(string sport)
        {
            Sport[] allSports = Sport.GetSports();
            Sport activeSport = new Sport();
            for (int i = 0; i < allSports.Length; i++)
            {
                if (allSports[i].Name == sport)
                {
                    activeSport = allSports[i];
                }
            }

            return View(activeSport);
        }
    }
}
