using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class ShopByCategoriesController : Controller
    {
        private readonly PortoDbContext _dbcontext;
        private readonly IWebHostEnvironment env;

        public ShopByCategoriesController(PortoDbContext portoDbContext, IWebHostEnvironment _env)
        {
            _dbcontext = portoDbContext;
            env = _env;
        }
        public IActionResult Index()
        {
            var group = _dbcontext.ShopByCategories.Include(x => x.ProductCategoryies).ToList();
            return View(group);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categorys = _dbcontext.productCategories.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ShopByCategory cases)
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
            string folder = @"images\ShopByCategories";
            var newImg = await cases.Photo.SaveAsync(env.WebRootPath, folder);
            cases.Image = newImg;
            _dbcontext.ShopByCategories.Add(cases);
            _dbcontext.SaveChanges();
            return Redirect("/Admin/ShopByCategories/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var search =await _dbcontext.ShopByCategories.FindAsync(id);
            _dbcontext.ShopByCategories.Remove(search);
            await _dbcontext.SaveChangesAsync();
            return View("/Admin/ShopCategories/index");
        }
    }
}
