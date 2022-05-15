using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class UserController : Controller
    {
        private readonly PortoDbContext dbContext;
        public UserController(PortoDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.Users.ToList());
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var delete = dbContext.Users.Find(id);
            if (delete==null)
            {
                return NotFound();
            }
            dbContext.Remove(delete);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/User/Index");
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var delete = dbContext.Users.Find(id);
            if (delete == null)
            {
                return NotFound();
            }
            return View(delete);
        }
    }
}
