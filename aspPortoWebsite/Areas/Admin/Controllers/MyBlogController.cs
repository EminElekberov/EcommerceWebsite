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
    [Authorize(Roles = "Admin")]

    public class MyBlogController : Controller
    {
        private readonly PortoDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public MyBlogController(PortoDbContext _dbContext, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            env = _env;
        }

        public IActionResult Index()
        {
            return View(dbContext.MyBlogCollections.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            MyBlogCollection clients = new MyBlogCollection();
            return View(clients);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MyBlogCollection clients)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!clients.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "eroorrr");
                return View(clients);
            }
            string folder = @"images\blog";
            //string folder = @"images\uploads";
            clients.Image = await clients.Photo.SaveAsync(env.WebRootPath, folder);
            await dbContext.MyBlogCollections.AddAsync(clients);
            await dbContext.SaveChangesAsync();
            return Redirect("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MyBlogCollection client = dbContext.MyBlogCollections.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(MyBlogCollection slider)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();

            }
            var sliderdb = dbContext.MyBlogCollections.Find(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    string folder = @"images\blog";
                    var newImg = await slider.Photo.SaveAsync(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, sliderdb.Image);
                    sliderdb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            sliderdb.Date = slider.Date;
            sliderdb.Title = slider.Title;
            sliderdb.Description = slider.Description;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/MyBlog/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MyBlogCollection Clients = await dbContext.MyBlogCollections.FindAsync(id);
            if (Clients == null)
            {
                return NotFound();
            }
            dbContext.MyBlogCollections.Remove(Clients);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/MyBlog/Index");

        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MyBlogCollection Clients = dbContext.MyBlogCollections.Find(id);
            if (Clients == null)
            {
                return NotFound();
            }
            return View(Clients);
        }
    }
}
