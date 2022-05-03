using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly PortoDbContext dbContext;
        public CategoriesController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            var group = dbContext.Categories.Include(x => x.ProductCategoryies).ToList();
            HomeVM homeVM = new HomeVM
            {
                Categories = dbContext.Categories.ToList()
            };
            return View(homeVM);
        }
        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var search = dbContext.Categories.Find(id);
            if (search==null)
            {
                return NotFound();
            }
            return View(search);
        }
    }
}
