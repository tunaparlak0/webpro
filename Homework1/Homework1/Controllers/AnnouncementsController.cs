using Microsoft.AspNetCore.Mvc;
using Homework1.Models;

namespace Homework1.Controllers{
    public class AnnouncementsController : Controller {
        public IActionResult Index(){
           var announcements = Repository.Announcements;
           ViewBag.AnnouncementCount = announcements.Count;
            return View(announcements);
        }
    }
}