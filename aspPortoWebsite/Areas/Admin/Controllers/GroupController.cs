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
        
    }
}
