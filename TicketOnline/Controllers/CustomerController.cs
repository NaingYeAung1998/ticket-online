using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TicketOnline.Entities;
using TicketOnline.Models;

namespace TicketOnline.Controllers
{
    [Authorize(Roles ="Customer")]
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _appEnvironment;


        public CustomerController(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IHostingEnvironment appEnvironment)
        {
            _userManager = userManager;
            _appEnvironment = appEnvironment;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Order(Order order)
        {
            var orderCount = _context.Orders.Count();
            var userid = _userManager.GetUserId(User);
            var customerid = _context.Customers.Where(x => x.CreatedBy == userid).FirstOrDefault().Id;
            order.OrderNo = orderCount+1;
            order.CreatedBy = customerid;
            order.CreatedOn = DateTime.UtcNow.AddHours(6).AddMinutes(30);

            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToAction("OrderIndex");
        }

        public IActionResult OrderIndex()
        {
            var userid = _userManager.GetUserId(User);
            var customerid = _context.Customers.Where(x => x.CreatedBy == userid).FirstOrDefault().Id;

            var orders = _context.Orders.Where(x => x.CreatedBy == customerid).ToList();

            foreach(var order in orders)
            {
                order.Ticket = _context.Tickets.Where(x => x.Id == order.TicketId).FirstOrDefault();
                order.Customer = _context.Customers.Where(x => x.Id == order.CreatedBy).FirstOrDefault();
            }

            if (orders == null)
            {
                var order = new Order();
                order.Customer = _context.Customers.Where(x => x.CreatedBy == userid).FirstOrDefault();
                orders.Add(order);
            }

            return View(orders);

        }

    }
}