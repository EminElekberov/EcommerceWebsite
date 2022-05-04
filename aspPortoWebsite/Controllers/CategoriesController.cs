using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using aspPortoWebsite.Repository;
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
        private readonly IBookRepository _bookRepository = null;

        public CategoriesController(PortoDbContext _dbContext, IBookRepository bookRepository)
        {
            dbContext = _dbContext;
            _bookRepository = bookRepository;

        }
        public async Task<IActionResult> Index(int page = 1)
        {
            int take = 1;
            ProductAndPaginationWm model = new ProductAndPaginationWm
            {
                Books = await dbContext.Books.Skip(take * (page - 1)).Take(take).ToListAsync(),
                Pagination = new PaginationModel(await dbContext.Groups.CountAsync(), take, page)
            };
            return View(model);
        }
        //public IActionResult Index()
        //{
        //    var group = dbContext.Categories.Include(x => x.ProductCategoryies).ToList();
        //    HomeVM homeVM = new HomeVM
        //    {
        //        Categories = dbContext.Categories.ToList(),
        //        Books=dbContext.Books.ToList()
        //    };
        //    return View(homeVM);
        //}
        public async  Task<IActionResult> Details(int id)
        {
          //  var data = await _bookRepository.GetBookById(id);
            HomeVM homeVM = new HomeVM
            {
                Books =dbContext.Books.Include(z=>z.bookGallery).Where(x=>x.ID==id).ToList()
            };
            return View(homeVM);
            //if (id==null)
            //{
            //    return NotFound();
            //}
            //var search = dbContext.Categories.Find(id);
            //if (search==null)
            //{
            //    return NotFound();
            //}
            //return View(search);
        }
        [HttpPost]
        public async Task<IActionResult> Details(Review review)
        {
            if (review == null)
            {
                return NotFound();
            }
            dbContext.Reviews.Add(review);
            await dbContext.SaveChangesAsync();
            return Redirect($"/categories/details/{review.Id}");
        }
    }
}
