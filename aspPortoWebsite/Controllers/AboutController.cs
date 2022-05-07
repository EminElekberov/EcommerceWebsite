using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class AboutController : Controller
    {

        private readonly PortoDbContext _dbContext;

        public AboutController(PortoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                ourStories=_dbContext.OurStories.ToList(),
                whyChooses=_dbContext.WhyChooses.ToList()
            };
            return View(homeVM);
        }
    }
}
