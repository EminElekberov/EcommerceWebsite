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


    public class ClientsController : Controller
    {
        private readonly PortoDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public ClientsController(PortoDbContext _dbContext, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            env = _env;
        }

        public IActionResult Index()
        {
            return View(dbContext.Clients.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            Clients clients = new Clients();
            return View(clients);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Clients clients)
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
            string folder = @"images\clients";
            //string folder = @"images\uploads";
            clients.Image = await clients.Photo.SaveAsync(env.WebRootPath, folder);
            await dbContext.Clients.AddAsync(clients);
            await dbContext.SaveChangesAsync();
            return Redirect("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Clients client = dbContext.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Clients slider)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/NOtfound/index");

            }
            var sliderdb = dbContext.Clients.Find(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    string folder = @"images\clients";
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
            sliderdb.Name = slider.Name;
            sliderdb.Job = slider.Job;
            sliderdb.Description = slider.Description;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Clients/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Clients Clients = await dbContext.Clients.FindAsync(id);
            if (Clients == null)
            {
                return NotFound();
            }
            dbContext.Clients.Remove(Clients);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Clients/Index");

        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Clients Clients = dbContext.Clients.Find(id);
            if (Clients == null)
            {
                return NotFound();
            }
            return View(Clients);
        }

    }
}
