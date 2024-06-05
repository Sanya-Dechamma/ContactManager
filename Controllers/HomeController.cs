using GTSLQP_ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GTSLQP_ContactManager.Controllers
{
    public class HomeController : Controller
    {
            private readonly ContactDbContext _context;

            public HomeController(ContactDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                var contacts = _context.Contacts.Include(c => c.Category).OrderBy(c => c.FirstName).ToList();
                return View(contacts);
            }
    }
}