using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class HobbyController : Controller
    {
        private readonly PortoDbContext dbContext;
        public HobbyController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            return View(dbContext.test.ToList());
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
            tests work = new tests
            {
                Name = name,

            };
            await dbContext.test.AddAsync(work);
            await dbContext.SaveChangesAsync();

            return Json(new
            {
                status = 200
            });
        }
        }
}
