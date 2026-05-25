using Microsoft.AspNetCore.Mvc;
using Gouda.Models;
using Gouda.Database;

namespace Gouda.Controllers
{
    public class EventController : Controller
    {
        private readonly GoudaDbContext _context;

        public EventController(GoudaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var events = _context.Events.ToList();
            return View(events);
        }

        [HttpPost]
        public IActionResult AddEvent(string eventName)
        {
            var newEvent = new EventModel
            {
                EventName = eventName
            };

            _context.Events.Add(newEvent);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
