using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class ContactFormController : Controller
    {
        private readonly PortoDbContext dbContext;
        public ContactFormController(PortoDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.ContactsForms.ToList());
        }
        [HttpGet]
        public IActionResult CreateOpinion(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ContactsForm contact = dbContext.ContactsForms.Find(id);
            if (contact == null)
            {
                return NotFound();

            }
            return View(contact);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOpinion(ContactsForm contact)
        {
            #region
            //if (!ModelState.IsValid)
            //{
            //    ModelState.AddModelError("Error", "Error");
            //    return View();
            //}
            //await _dbcontext.Contacts.AddAsync(contact);
            //await _dbcontext.SaveChangesAsync();
            //return Redirect("Index");
            #endregion
            if (ModelState.IsValid)
            {
                return View(contact);
            }
            var sliderdb = dbContext.ContactsForms.Find(contact.Id);
            sliderdb.MyOpinion = contact.MyOpinion;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/ContactForm/Index");

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            ContactsForm contact = await dbContext.ContactsForms.FindAsync(id);
            if (contact == null)
            {
                return Redirect("/NOtfound/index");

            }
            dbContext.ContactsForms.Remove(contact);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/ContactForm/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            var  contact = dbContext.ContactsForms.Find(id);
            if (contact == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(contact);
        }
    }
}
