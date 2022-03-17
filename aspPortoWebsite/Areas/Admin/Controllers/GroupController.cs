using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GroupController : Controller
    {
        private readonly PortoDbContext dbContext;
        public GroupController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            return View(dbContext.Groups.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Create(string name)
        {
            if (name == null)
            {
                return Json(new
                {
                    status = 400
                });
            }
            Group group = new Group
            {
                Fullname = name
            };


            await dbContext.Groups.AddAsync(group);
            await dbContext.SaveChangesAsync();

            return Json(new
            {
                status = 200
            });
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Group grp = await dbContext.Groups.FindAsync(id);
            if (grp == null) return NotFound();
            dbContext.Groups.Remove(grp);
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Groups/Index");
        }

    }
}
