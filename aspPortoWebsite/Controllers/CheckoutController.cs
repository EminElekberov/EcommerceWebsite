using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using aspPortoWebsite.Models.ForCart;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly PortoDbContext portoDbContext;
        private readonly UserManager<User> _userManager;
        public CheckoutController(PortoDbContext portoDb, UserManager<User> userManager)
        {
            portoDbContext = portoDb;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart; 
            if (cart!=null)
            {
                ViewBag.total = cart.Sum(item => item.Books.PresentPrice * item.Quantity);
            }
            //Checkout checkout = new Checkout();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Sales checkout)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            checkout.UserId = user.Id;
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            foreach (var item in cart)
            {
                Sales sales = new Sales
                {
                    UserId = user.Id,
                    BooksId = item.Books.ID,
                    Count = item.Quantity,
                    Price=item.Books.PresentPrice*item.Quantity,
                    CompanyName=checkout.CompanyName,
                    Country=checkout.Country,
                    EmailAddress=checkout.EmailAddress,
                    FirstName=checkout.FirstName,
                    LastName=checkout.LastName,
                    OrderInformation=checkout.OrderInformation,
                    PhoneNumber=checkout.PhoneNumber,
                    SteetAddress=checkout.SteetAddress,
                    Town=checkout.Town

                };
                await portoDbContext.Sales.AddAsync(sales);
            }
            await portoDbContext.SaveChangesAsync();
            //await portoDbContext.Checkouts.AddAsync(checkout);
            //await portoDbContext.SaveChangesAsync();
            return RedirectToAction("/Home/Index");
        }
    }
}
