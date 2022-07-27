using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using aspPortoWebsite.Models.ForBook;
using aspPortoWebsite.Repository;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class CategoryController : Controller
    {
        private readonly PortoDbContext _dbcontext;
        private readonly IWebHostEnvironment env;
        private readonly IBookRepository _bookRepository = null;
        public CategoryController(PortoDbContext portoDbContext, IWebHostEnvironment _env, IBookRepository bookRepository)
        {
            _dbcontext = portoDbContext;
            env = _env;
            _bookRepository = bookRepository;

        }

        public IActionResult Index()
        {
            var group = _dbcontext.Books.ToList();
            return View(group);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categorys = _dbcontext.productCategories.ToList();
            ViewBag.Color = _dbcontext.Colors.ToList();
            ViewBag.Size = _dbcontext.Sizes.ToList();
            ViewBag.Packets = _dbcontext.Books.ToList();
            return View();
        }
        #region
        //[HttpPost]
        //public async Task<IActionResult> Create(Category cases)
        //{
        //    #region
        //    if (!ModelState.IsValid && cases.Photo == null)
        //    {
        //        return Redirect("/NOtfound/ErrorPage");
        //    }
        //    if (cases.GalleryFiles != null)
        //    {
        //        string folders = "images/gallery/";

        //        cases.Gallery = new List<GalleryModel>();

        //        foreach (var file in cases.GalleryFiles)
        //        {
        //            var gallery = new GalleryModel()
        //            {
        //                Name = file.FileName,
        //                URL = await UploadImage(folders, file)
        //            };
        //            cases.Gallery.Add(gallery);
        //        }
        //    }
        //    if (!cases.Photo.IsImage())
        //    {
        //        ModelState.AddModelError("photo", "Img formati dogru deyil");
        //        return View(cases);
        //    }
        //    string folder = @"images\categories";
        //    var newImg = await cases.Photo.SaveAsync(env.WebRootPath, folder);
        //    cases.Image = newImg;
        //    _dbcontext.Categories.Add(cases);
        //    _dbcontext.SaveChanges();
        //    return Redirect("/Admin/portfol/Index");
        //    #endregion
        //}
        #endregion
        [HttpPost]
        public async Task<IActionResult> Create(Category bookModel)
        {

            if (!ModelState.IsValid)
            {
                if (bookModel.Photo != null)
                {
                    string folder = @"images\categories";
                    var newImg = await bookModel.Photo.SaveAsync(env.WebRootPath, folder);
                    bookModel.Image = newImg;
                    // bookModel.Image = await UploadImage(folder, bookModel.Photo);
                }
                if (bookModel.GalleryFiles != null)
                {
                    string folder = "images/gallery/";

                    bookModel.Gallery = new List<GalleryModel>();

                    foreach (var file in bookModel.GalleryFiles)
                    {
                        var gallery = new GalleryModel()
                        {
                            Name = await UploadImage(folder, file)
                        };
                        bookModel.Gallery.Add(gallery);
                    }
                }
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    BooksToColor booksToColor = new BooksToColor();
                    foreach (var item in bookModel.ColorId)
                    {
                        BooksToColor packet = new BooksToColor
                        {
                            BookId = id,
                            ColorId = item
                        };
                        _dbcontext.BooksToColors.Add(packet);
                    }
                    SizeToBooks sizeToBooks = new SizeToBooks();
                    foreach (var item in bookModel.SizeId)
                    {
                        SizeToBooks size = new SizeToBooks
                        {
                            BooksId = id,
                            SizeId = item
                        };
                        _dbcontext.SizeToBooks.Add(size);
                    }
                    _dbcontext.SaveChanges();


                    return RedirectToAction(nameof(Create), new { isSuccess = true, bookId = id });
                }
            }
            return View();
        }
        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {
            string result = Guid.NewGuid().ToString() + "_" + file.FileName;
            folderPath += result;
            string serverFolder = Path.Combine(env.WebRootPath, folderPath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return result;
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            var cases = await _dbcontext.Books.FindAsync(id);
            if (cases == null)
            {
                return NotFound();

            }
            _dbcontext.Books.Remove(cases);
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
            var cases = _dbcontext.Books.Find(id);
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
            var sliderdb = _dbcontext.Books.Find(cases.ID);
            if (cases.Photo != null)
            {
                try
                {
                    string folder = @"images\categories\";
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
            sliderdb.PresentPrice = cases.PresentPrice;
            sliderdb.SizeGuid = cases.SizeGuid;
            sliderdb.Sku = cases.Sku;
            sliderdb.AdditionalInformation = cases.AdditionalInformation;
            sliderdb.Description = cases.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/category/Index");
        }
    }
}
