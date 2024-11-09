using Microsoft.AspNetCore.Mvc; 
using Homework1.Models;
namespace Homework1.Controllers{
    public class AddAnnouncementsController : Controller {
         [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                Repository.CreateAnnouncement(announcement);
                return RedirectToAction("Index", "Announcements");
            }
            return View(announcement);
        }
        
        
    }
}