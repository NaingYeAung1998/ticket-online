using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TicketOnline.Entities;
using TicketOnline.Models;

namespace TicketOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _appEnvironment;


        public HomeController(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IHostingEnvironment appEnvironment)
        {
            _userManager = userManager;
            _appEnvironment = appEnvironment;
            _context = context;
        }
        public IActionResult Index()
        {
            var upcoming = _context.Tickets.Where(x => x.CreatedOn < DateTime.UtcNow.AddHours(6).AddMinutes(30)).OrderBy(x=>x.Name).Take(2).ToList();

            var tickets = _context.Tickets.Take(3).ToList();

            ViewBag.Upcomings = upcoming;
            ViewBag.Tickets = tickets;
            return View();
        }

        public IActionResult Tickets()
        {
            var tickets = _context.Tickets.OrderByDescending(x=>x.CreatedOn).ToList();
            return View(tickets);
        }

        [HttpGet]
        public IActionResult TicketDetail([FromQuery]Guid id)
        {
            var ticket = _context.Tickets.Where(x=>x.Id==id).FirstOrDefault();
            if (ticket != null)
            {
                return View(ticket);
            }
            else
            {
                return NotFound();
            }
            
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
