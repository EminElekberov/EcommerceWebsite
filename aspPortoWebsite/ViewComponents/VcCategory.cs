using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using aspPortoWebsite.Models.ForCart;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.ViewComponents
{
    public class VcCategory:ViewComponent
    {
        private readonly PortoDbContext dbContext;
        public VcCategory(PortoDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IViewComponentResult Invoke()
        {
            var model = dbContext.Categories.OrderBy(x => x.Name).ToList();
            return View(model);
           
        }
    }
}
