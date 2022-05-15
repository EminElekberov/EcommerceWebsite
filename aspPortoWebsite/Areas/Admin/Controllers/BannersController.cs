using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class BannersController : Controller
    {
        private readonly PortoDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public BannersController(PortoDbContext _dbContext, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            env = _env;
        }

        public async Task<IActionResult> Index()
        {
            return View(dbContext.Banners.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            Banner slider = new Banner();
            return View(slider);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Banner slider)
        {
            if (!ModelState.IsValid && slider.Photo == null)
            {
                ModelState.AddModelError("photo", "Sekil daxil edin");
                return View();
            }
            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(slider);
            }
            string folder = @"images\banners";
            var newImg = await slider.Photo.SaveAsync(env.WebRootPath, folder);
            slider.Image = newImg;

            await dbContext.Banners.AddAsync(slider);
            await dbContext.SaveChangesAsync();

            return Redirect("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Banner slider = dbContext.Banners.Find(id);
            if (id == null)
            {
                return NotFound();
            }
            return View(slider);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Banner slider)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }
            var sliderDb = dbContext.Banners.Find(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    string folder = @"images\banners";
                    var newImg = await slider.Photo.SaveAsync(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, sliderDb.Image);
                    sliderDb.Image = newImg;
                    //
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    return View();
                }
            }
            sliderDb.Title = slider.Title;
            sliderDb.Description = slider.Description;
            sliderDb.ButtonText = slider.ButtonText;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Banners/Index");
        }
        //silmek ucun isdiafde olunur burda id ile secib delete edirik
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Banner slider = await dbContext.Banners.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }
            dbContext.Banners.Remove(slider);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Banners/Index");
        }
        // bu ise uzirne click etdikde hemin id olan rowun melumatlarini getiririk
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Banner slider = await dbContext.Banners.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }
    }
}
