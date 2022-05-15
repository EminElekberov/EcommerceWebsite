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

    public class WorkController : Controller
    {
        private readonly PortoDbContext dbContext;
        public WorkController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            return View(dbContext.Works.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public async Task<JsonResult> Create(string name,string title,string description,string text,string link)
        {
            if (name == null && title == null && description == null && text == null && link == null)
            {
                return Json(new
                {
                    status = 400
                });
            }
            Work work = new Work
            {
                Header=name,
                Title=title,
                Description=description,
                Buttontext=text,
                ButtonLink=link
            };
            await dbContext.Works.AddAsync(work);
            await dbContext.SaveChangesAsync();

            return Json(new
            {
                status = 200
            });
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Work work = await dbContext.Works.FindAsync(id);
            if (work == null) return NotFound();
            dbContext.Works.Remove(work);
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/work/Index");
        }
    }
}
