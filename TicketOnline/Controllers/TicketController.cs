using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TicketOnline.Entities;
using TicketOnline.Models;

namespace TicketOnline.Controllers
{
    public class TicketController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _appEnvironment;


        public TicketController(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IHostingEnvironment appEnvironment)
        {
            _userManager = userManager;
            _appEnvironment = appEnvironment;
            _context = context;
        }
        public IActionResult Index()
        {
            var tickets = _context.Tickets.ToList();
            return View(tickets);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromBody]Ticket ticket)
        {
            ticket.Id = Guid.NewGuid();
            ticket.CoverPhoto = CreateImage(ticket.CoverPhoto);
            ticket.TicketPhoto = CreateImage(ticket.TicketPhoto);
            ticket.CreatedOn = DateTime.UtcNow.AddHours(6).AddMinutes(30);

            _context.Tickets.Add(ticket);
            _context.SaveChanges();

            return Ok(ticket);
        }

        public string CreateImage(string photo)
        {
            string result = Regex.Replace(photo, "^data:image/[a-zA-Z]+;base64,", string.Empty);
            byte[] byt = Convert.FromBase64String(result);

            string filename = Guid.NewGuid().ToString() + ".jpg";
            var save_path = Path.Combine(_appEnvironment.WebRootPath, "img\\Posts\\");

            string img_path = Path.Combine(save_path, filename);
            System.IO.File.WriteAllBytes(img_path, byt);

            return filename;
        }

        [HttpGet]
        public IActionResult Orders()
        {
            var orders = _context.Orders.OrderByDescending(x => x.CreatedOn).ToList();
            foreach(var order in orders)
            {
                order.Ticket = _context.Tickets.Where(x => x.Id == order.TicketId).FirstOrDefault();
                order.Customer = _context.Customers.Where(x => x.Id == order.CreatedBy).FirstOrDefault();
            }
            return View(orders);
        }

    }
}