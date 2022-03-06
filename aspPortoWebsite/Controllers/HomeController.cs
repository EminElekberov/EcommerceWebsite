using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortoDbContext dbContext;
        public HomeController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM vM = new HomeVM
            {
                Categories = await dbContext.Categories.ToListAsync(),
                Sliders = await dbContext.Sliders.ToListAsync(),
            };

            return View(vM);
        }
       
        public IActionResult AboutPage()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category category = dbContext.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
    }
}
