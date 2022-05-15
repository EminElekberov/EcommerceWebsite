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

    public class HomeFooterController : Controller
    {
        private readonly PortoDbContext dbContext;
        public HomeFooterController(PortoDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.HomeFooters.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(HomeFooter about)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await dbContext.HomeFooters.AddAsync(about);
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/HomeFooter/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            HomeFooter about = dbContext.HomeFooters.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(HomeFooter about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            var chosedb = dbContext.HomeFooters.Find(about.Id);
            chosedb.Email = about.Email;
            chosedb.Address = about.Address;
            chosedb.Phone = about.Phone;
            chosedb.WorkHours = about.WorkHours;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/About/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            HomeFooter choose = await dbContext.HomeFooters.FindAsync(id);
            if (choose == null)
            {
                return Redirect("/NOtfound/index");

            }
            dbContext.HomeFooters.Remove(choose);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/HomeFooter/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            var findId = dbContext.HomeFooters.Find(id);
            if (findId == null)
            {
                return NotFound();

            }
            return View(findId);
        }
    }
}
