using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using aspPortoWebsite.Models.ForBook;
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
            int take = 3;
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
        [HttpGet]
        public async  Task<IActionResult> Details(int id)
        {
            HomeVM homeVM = new HomeVM
            {
                Books = dbContext.Books.Include(z=>z.bookGallery).Include(z=>z.productCategory).Where(x=>x.ID==id).ToList(),
                listRewiew=dbContext.Reviews.Where(x=>x.BooksId==id).ToList(),
                booksToColors=await dbContext.BooksToColors.Include(x=>x.Color).Include(x=>x.Books).Where(x=>x.BookId==id).ToListAsync(),
                sizeToBooks=await dbContext.SizeToBooks.Include(x=>x.Size).Include(x=>x.Books).Where(x=>x.BooksId==id).ToListAsync()
            };
            return View(homeVM);
           
        }
        [HttpPost]
        public async Task<IActionResult> Details(Review review)
        {
           // var user = await dbContext.Books.FindAsync(review.Id);
            if (review == null)
            {
                return NotFound();
            }
            dbContext.Reviews.Add(new Review { BooksId=review.Id,Message=review.Message,Email=review.Email,Name=review.Name,Date=DateTime.Now.Date });
            await dbContext.SaveChangesAsync();
            return Redirect($"/categories/details/{review.Id}");
        }
        public async Task<IActionResult> Search(string SeachText = "")
        {
            List<Books> category;
            if (SeachText != "" && SeachText != null)
            {
                category = dbContext.Books.Where(p => p.Name.ToLower() == SeachText.ToLower()).ToList();
            }
            else
            {
                category = dbContext.Books.ToList();
            }
            return View(category);
        }
        public async Task<IActionResult> Search2(string SeachText = "")
        {
            List<Books> category;
            if (SeachText != "" && SeachText != null)
            {
                category = dbContext.Books.Include(x=>x.productCategory).Where(p => p.Name.ToLower() == SeachText.ToLower()).ToList();
            }
            else
            {
                category = dbContext.Books.ToList();
            }
            return View(category);
        }
    }
}
