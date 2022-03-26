using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class LstrogeController : Controller
    {
        private readonly PortoDbContext dbContext;
        private readonly UserManager<User> userManager;
        public LstrogeController(PortoDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Basket()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Basket(string username, List<Product> products)
        {
            if (products == null)
            {
                return Json(new
                {
                    status = 400
                });

            }

            User user = await userManager.FindByNameAsync(username);
            await dbContext.Products.AddRangeAsync(products);
            await dbContext.SaveChangesAsync();
            foreach (var item in products)
            {
                UserToProduct userToProduct = new UserToProduct()
                {
                    UserId = user.Id,
                    ProductId = dbContext.Products.FirstOrDefault(x => x.productid == item.productid).id
                };
                await dbContext.UserToProducts.AddAsync(userToProduct);
            }

            await dbContext.SaveChangesAsync();

            return Json(new
            {
                status = 200
            });

        }
    }
}
