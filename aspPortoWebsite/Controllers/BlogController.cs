using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class BlogController : Controller
    {
        private readonly PortoDbContext _dbContext;

        public BlogController(PortoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.MyBlogCollections.ToList());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var search =await _dbContext.MyBlogCollections.FindAsync(id);
            if (search==null)
            {
                return NotFound();
            }
            return View(search);
        }
    }
}
