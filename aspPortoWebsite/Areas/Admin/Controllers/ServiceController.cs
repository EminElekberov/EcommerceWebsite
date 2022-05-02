using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly PortoDbContext dbContext;
        public ServiceController(PortoDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.Services.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Service about)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await dbContext.Services.AddAsync(about);
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Service/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Service about = dbContext.Services.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Service about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            var chosedb = dbContext.Services.Find(about.Id);
            chosedb.Title = about.Title;
            chosedb.Description = about.Description;
            chosedb.Header = about.Header;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Service/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            Service choose = await dbContext.Services.FindAsync(id);
            if (choose == null)
            {
                return Redirect("/NOtfound/index");

            }
            dbContext.Services.Remove(choose);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Service/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var findId = dbContext.Services.Find(id);
            if (findId == null)
            {
                return NotFound();

            }
            return View(findId);
        }
    }
}
