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
    public class VcCart : ViewComponent
    {
        private readonly PortoDbContext dbContext;
        public VcCart(PortoDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }

        public IViewComponentResult Invoke()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            if (cart != null)
            {
                ViewBag.total = cart.Sum(item => item.Books.PresentPrice * item.Quantity);
            }
            return View();
        }
    }
}
