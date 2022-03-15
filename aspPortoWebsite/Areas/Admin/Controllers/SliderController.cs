using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles ="Admin")]
    public class SliderController : Controller
    {

        private readonly PortoDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public SliderController(PortoDbContext _dbContext, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            env = _env;
        }

        public IActionResult Index()
        {
            return View(dbContext.Sliders.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            Slider slider = new Slider();
            return View(slider);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
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
            string folder = @"images\demoes\demo3\slider";
            var newImg= await slider.Photo.SaveAsync(env.WebRootPath, folder);
            slider.Image = newImg;
            
           await dbContext.Sliders.AddAsync(slider);
           await dbContext.SaveChangesAsync();

            return Redirect("Index");  
        }

        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Slider slider = dbContext.Sliders.Find(id);
            if (id==null)
            {
                return NotFound();
            }
            return View(slider);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }
            var sliderDb = dbContext.Sliders.Find(slider.ID);
            if (slider.Photo!=null)
            {
                try
                {
                    string folder = @"images\demoes\demo3\slider";
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
            sliderDb.Price = slider.Price;
            sliderDb.DisCount = slider.DisCount;
            sliderDb.TrendWord = slider.TrendWord;
            sliderDb.ClothType = slider.ClothType;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Slider/Index");
        }
        //silmek ucun isdiafde olunur burda id ile secib delete edirik
        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Slider slider =await dbContext.Sliders.FindAsync(id);
            if (slider==null)
            {
                return NotFound();
            }
            dbContext.Sliders.Remove(slider);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Slider/Index");
        }
        // bu ise uzirne click etdikde hemin id olan rowun melumatlarini getiririk
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider slider = await dbContext.Sliders.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }

    }
}
