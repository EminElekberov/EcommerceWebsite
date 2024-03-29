﻿using aspPortoWebsite.Extension;
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

        public async Task<IActionResult> Index(int page=1)
        {
            int take = 1;
            HomeVM vM = new HomeVM
            {
                Pagination = new PaginationModel(await dbContext.Books.CountAsync(), take, page),
                Categories = await dbContext.Categories.ToListAsync(),
                Sliders = await dbContext.Sliders.ToListAsync(),
                shopByCategories = await dbContext.ShopByCategories.Include(x => x.ProductCategoryies).ToListAsync(),
                banners = await dbContext.Banners.ToListAsync(),
                Books = await dbContext.Books.Include(x => x.productCategory).ToListAsync(),
                services = await dbContext.Services.ToListAsync(),
                productCategories = await dbContext.productCategories.ToListAsync()
            };

            return View(vM);
        }
        [HttpPost]
        public async Task<IActionResult> Index(ContactsForm contactsForm)
        {
            await dbContext.ContactsForms.AddAsync(contactsForm);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("/Home/Index");
        }
        public async Task<IActionResult> ShopCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            HomeVM homeVM = new HomeVM
            {
                Books = await dbContext.Books.Include(x => x.productCategory).Where(x => x.ProductsCategoryId == id).ToListAsync(),
                productCategories = await dbContext.productCategories.ToListAsync(),
                BooksCategory = await dbContext.Books.Include(x => x.productCategory).ToListAsync(),
                colors =await dbContext.Colors.ToListAsync(),
                sizes=await dbContext.Sizes.ToListAsync()
            };
            return View(homeVM);
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
