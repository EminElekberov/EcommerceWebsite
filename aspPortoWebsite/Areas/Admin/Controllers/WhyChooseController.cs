using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WhyChooseController : Controller
    {
        private readonly PortoDbContext dbContext;
        public WhyChooseController(PortoDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.WhyChooses.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(WhyChoose about)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await dbContext.WhyChooses.AddAsync(about);
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/WhyChoose/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            WhyChoose about = dbContext.WhyChooses.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(WhyChoose about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            var chosedb = dbContext.WhyChooses.Find(about.Id);
            chosedb.Title = about.Title;
            chosedb.IconLink = about.IconLink;
            chosedb.Description = about.Description;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/WhyChoose/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            WhyChoose choose = await dbContext.WhyChooses.FindAsync(id);
            if (choose == null)
            {
                return NotFound();

            }
            dbContext.WhyChooses.Remove(choose);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/WhyChoose/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            var findId = dbContext.WhyChooses.Find(id);
            if (findId == null)
            {
                return NotFound();

            }
            return View(findId);
        }
    }
}
