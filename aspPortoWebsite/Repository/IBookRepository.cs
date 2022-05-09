using aspPortoWebsite.Models;
using aspPortoWebsite.Models.ForBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Repository
{
   public interface IBookRepository
    {
        Task<int> AddNewBook(Category model);
       // Task<Books> AddNewBooks(Category model);
        Task<List<Category>> GetAllBooks();
        Task<Books> GetBookById(int id);
        Task<List<Category>> GetTopBooksAsync(int count);
        List<Category> SearchBook(string title, string authorName);

        string GetAppName();
    }
}
