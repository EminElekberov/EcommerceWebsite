using aspPortoWebsite.Models;
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
        public CheckoutController(PortoDbContext portoDb)
        {
            portoDbContext = portoDb;
        }
        public IActionResult Index()
        {
            Checkout checkout = new Checkout();
            return View(checkout);
        }
        [HttpPost]
        public async Task<IActionResult> Index(Checkout checkout)
        {
            await portoDbContext.Checkouts.AddAsync(checkout);
            await portoDbContext.SaveChangesAsync();
            return Redirect("Index");
        }
    }
}
