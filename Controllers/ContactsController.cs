using GTSLQP_ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GTSLQP_ContactManager.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactDbContext _context;

        public ContactsController(ContactDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            CategoryDDList();
            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var contact = _context.Contacts.Find(id);
            CategoryDDList();
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                {
                    _context.Contacts.Add(contact);
                }
                else
                {
                    _context.Contacts.Update(contact);
                }
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                CategoryDDList();
                return View(contact);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var contact = _context.Contacts.Find(id);
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var contact = _context.Contacts
                .Include(c => c.Category)
                .FirstOrDefault(c => c.ContactId == id);
            return View(contact);
        }

        private void CategoryDDList()
        {
            var categories = _context.Categories?.ToList() ?? new List<Category>();
            ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
        }
    }
}
