using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
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

        public IActionResult Share(string emailTo, string ourScore, string theirScore)
        {
            SmtpClient email = new SmtpClient("smtp.gmail.com",587);
            email.EnableSsl = true;
            email.UseDefaultCredentials = false;
            email.Credentials = new NetworkCredential("sportstracker35@gmail.com", "bytenhzdsodpkkid");
            MailMessage message = new MailMessage();
            message.From = new MailAddress("sportstracker35@gmail.com");
            message.To.Add(emailTo);
            message.Subject = "Sports Tracker game results";
            message.Body = "Here are your game details.  We scored " + ourScore + " and they scored " + theirScore;
            email.Send(message);
            return View();
        }
    }
}
