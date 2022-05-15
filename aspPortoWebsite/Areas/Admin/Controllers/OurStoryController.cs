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

    public class OurStoryController : Controller
    {
        private readonly PortoDbContext dbContext;
        public OurStoryController(PortoDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.OurStories.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(OurStory about)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await dbContext.OurStories.AddAsync(about);
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/OurStory/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            OurStory about = dbContext.OurStories.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(OurStory about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            var chosedb = dbContext.OurStories.Find(about.Id);
            chosedb.Description = about.Description;
            chosedb.Phorizm = about.Phorizm;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/OurStory/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            OurStory choose = await dbContext.OurStories.FindAsync(id);
            if (choose == null)
            {
                return Redirect("/NOtfound/index");

            }
            dbContext.OurStories.Remove(choose);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/OurStory/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            var findId = dbContext.OurStories.Find(id);
            if (findId == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(findId);
        }
    }
}
