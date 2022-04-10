using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly PortoDbContext portoDbContext;
        private readonly IWebHostEnvironment env;

        public CategoryController(PortoDbContext dbContext, IWebHostEnvironment _env)
        {
            portoDbContext = dbContext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(portoDbContext.Categories.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            Category category = new Category();
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            if (!category.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "eroorrr");
                return View(category);
            }
            string folder = @"images\demoes\demo3\categories";
            //string folder = @"images\uploads";
            category.Image =await category.Photo.SaveAsync(env.WebRootPath, folder);
            await portoDbContext.Categories.AddAsync(category);
            await portoDbContext.SaveChangesAsync();
            return Redirect("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Category category = portoDbContext.Categories.Find(id);
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            Category categoryDb = portoDbContext.Categories.Find(category.ID);
            if (!category.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(category);
            }
            if (category.Photo!=null)
            {
                try
                {
                    string folder = @"images\demoes\demo3\categories";
                    var newImg =await category.Photo.SaveAsync(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, categoryDb.Image);
                    categoryDb.Image =newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("Error", "Unexpected error");
                    throw;
                    //
                }

            }
            categoryDb.Description = category.Description;
            categoryDb.Name = category.Name;
            await portoDbContext.SaveChangesAsync();
            return Redirect("/Admin/Category/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Category category = await portoDbContext.Categories.FindAsync(id);
            if (category==null)
            {
                return NotFound();
            }
             portoDbContext.Categories.Remove(category);
            await portoDbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Category/Index");

        }
        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Category category = portoDbContext.Categories.Find(id);
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
    }
}
