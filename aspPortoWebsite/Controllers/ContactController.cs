using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly PortoDbContext _dbcontext;
        public ContactController(PortoDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                homeFooters=_dbcontext.HomeFooters.ToList(),
                askedQuestions=_dbcontext.AskedQuestions.ToList()
            };
            return View(homeVM);
        }
        [HttpPost]
        public IActionResult Index(ContactsForm contact)
        {
            if (contact == null)
            {
                return NotFound();
            }
            _dbcontext.ContactsForms.Add(contact);
            _dbcontext.SaveChanges();
            return Redirect("/Contact/index");
        }
    }
}
