using aspPortoWebsite.Models;
using aspPortoWebsite.Models.ForBook;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly PortoDbContext _context = null;
        private readonly IConfiguration _configuration;

        public BookRepository(PortoDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<int> AddNewBook(Category model)
        {
            var newBook = new Books()
            {
                Name = model.Name,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                PresentPrice = model.PresentPrice,
                UpdatedOn = DateTime.UtcNow,
                PastPrice = model.PastPrice,
                Image = model.Image,
                Sku = model.Sku,
                SizeGuid = model.SizeGuid,
                AdditionalInformation = model.AdditionalInformation,
                ProductsCategoryId = model.ProductsCategoryId
            };

            newBook.bookGallery = new List<BookGallery>();

            foreach (var file in model.Gallery)
            {
                newBook.bookGallery.Add(new BookGallery()
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }

            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.ID;
        }

        //public async Task<Books> AddNewBooks(Category model)
        //{
        //    var newBook = new Books()
        //    {
        //        Name = model.Name,
        //        CreatedOn = DateTime.UtcNow,
        //        Description = model.Description,
        //        PresentPrice = model.PresentPrice,
        //        UpdatedOn = DateTime.UtcNow,
        //        PastPrice = model.PastPrice,
        //        Image = model.Image,
        //        Sku = model.Sku,
        //        SizeGuid = model.SizeGuid,
        //        AdditionalInformation = model.AdditionalInformation,
        //        ProductsCategoryId = model.ProductsCategoryId
        //    };

        //    newBook.bookGallery = new List<BookGallery>();

        //    foreach (var file in model.Gallery)
        //    {
        //        newBook.bookGallery.Add(new BookGallery()
        //        {
        //            Name = file.Name,
        //            URL = file.URL
        //        });
        //    }

        //    await _context.Books.AddAsync(newBook);
        //    await _context.SaveChangesAsync();

        //    return newBook;
        //}
        public async Task<List<Category>> GetAllBooks()
        {
            return await _context.Books
                  .Select(model => new Category()
                  {
                      Name = model.Name,
                      Description = model.Description,
                      PresentPrice = model.PresentPrice,
                      PastPrice = model.PastPrice,
                      Image = model.Image,
                      Sku = model.Sku,
                      SizeGuid = model.SizeGuid,
                      AdditionalInformation = model.AdditionalInformation,
                      ProductsCategoryId = model.ProductsCategoryId
                  }).ToListAsync();
        }

        public string GetAppName()
        {
            return _configuration["AppName"];
        }

        public async Task<Books> GetBookById(int id)
        {
            return await _context.Books.Include(x => x.bookGallery).FirstOrDefaultAsync(x => x.ID == id);
                
        }

        public async Task<List<Category>> GetTopBooksAsync(int count)
        {
            return await _context.Books
                  .Select(model => new Category()
                  {
                      Name = model.Name,
                      Description = model.Description,
                      PresentPrice = model.PresentPrice,
                      PastPrice = model.PastPrice,
                      Image = model.Image,
                      Sku = model.Sku,
                      SizeGuid = model.SizeGuid,
                      AdditionalInformation = model.AdditionalInformation,
                      ProductsCategoryId = model.ProductsCategoryId
                  }).Take(count).ToListAsync();
        }

        public List<Category> SearchBook(string title, string authorName)
        {
            return null;
        }
    }
}
