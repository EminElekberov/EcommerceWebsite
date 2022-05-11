using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class FilterController : Controller
    {
        private readonly PortoDbContext portoDbContext;
        public FilterController(PortoDbContext portoDb)
        {
            portoDbContext = portoDb;
        }
        public async Task<IActionResult> Index(int rangePrimary, int size)
        {
            List<SizeToBooks> sizes=new List<SizeToBooks>();
            //List<SizeToBooks> sizes;
            if (rangePrimary == null)
            {
                return NotFound();
            }
            if (rangePrimary!=0 && size==0)
            {
                sizes= portoDbContext.SizeToBooks.Include(x => x.Books).Include(x => x.Size).Where(x =>x.Books.PresentPrice <= rangePrimary).ToList();
            }
            else if(rangePrimary!=null &&  size!=0)
            {
                sizes = portoDbContext.SizeToBooks.Include(x => x.Books).Include(x => x.Size).Where(x => x.SizeId == size && x.Books.PresentPrice <= rangePrimary).ToList();
            }
            else
            {
                return RedirectToAction("/Home/Index");
            }
            return View(sizes);
        }
    }
}
