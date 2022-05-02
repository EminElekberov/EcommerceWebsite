using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly PortoDbContext _dbcontext;
        private readonly IWebHostEnvironment env;

        public CategoryController(PortoDbContext portoDbContext, IWebHostEnvironment _env)
        {
            _dbcontext = portoDbContext;
            env = _env;
        }

        public IActionResult Index()
        {
            var group = _dbcontext.Categories.Include(x => x.ProductCategoryies).ToList();
            return View(group);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categorys = _dbcontext.productCategories.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category cases)
        {
            if (!ModelState.IsValid && cases.Photo == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            if (!cases.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(cases);
            }
            string folder = @"images\categories";
            var newImg = await cases.Photo.SaveAsync(env.WebRootPath, folder);
            cases.Image = newImg;
            _dbcontext.Categories.Add(cases);
            _dbcontext.SaveChanges();
            return Redirect("/Admin/portfol/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            var cases = await _dbcontext.Categories.FindAsync(id);
            if (cases == null)
            {
                return NotFound();

            }
            _dbcontext.Categories.Remove(cases);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/category/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cases = _dbcontext.Categories.Find(id);
            if (cases == null)
            {
                return NotFound();

            }
            return View(cases);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category cases)
        {
            if (!ModelState.IsValid)
            {
                return View(cases);
            }
            var sliderdb = _dbcontext.Categories.Find(cases.ID);
            if (cases.Photo != null)
            {
                try
                {
                    string folder = @"images\portfolio";
                    var newImg = await cases.Photo.SaveAsync(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, sliderdb.Image);
                    sliderdb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            sliderdb.Name = cases.Name;
            sliderdb.PastPrice = cases.PastPrice;
            sliderdb.PresentPrice= cases.PresentPrice;
            sliderdb.SizeGuid= cases.SizeGuid;
            sliderdb.Sku= cases.Sku;
            sliderdb.AdditionalInformation= cases.AdditionalInformation;
            sliderdb.Description= cases.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/category/Index");
        }
    }
}
