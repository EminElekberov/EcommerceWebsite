using aspPortoWebsite.Models;
using aspPortoWebsite.Models.ForCart;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class CartController : Controller
    {
        private readonly PortoDbContext dbContext;

        public CartController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult Index()
        {
            return View(GetCart());
        }
        public async Task<IActionResult> AddToCart(int id)
        {
            var product = dbContext.Books.FirstOrDefault(i => i.ID == id);
            if (product == null)
            {
                GetCart().AddProduct(product, 1);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveFromCart(int id)
        {
            var product = dbContext.Books.FirstOrDefault(i => i.ID == id);

            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }
        public Cart GetCart()
        {
            //var cart = (Cart)Session["Cart"];
            var cart = JsonConvert.DeserializeObject<Cart>(HttpContext.Session.GetString("Cart"));

            if (cart == null)
            {
                cart = new Cart();
                //  Session["Cart"] = cart;
            }
            return cart;
        }
        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }
        public async Task<IActionResult> Checkout(ShippingDetails entity)
        {
            var cart = GetCart();
            if (cart._cardLines.Count==0)
            {
                ModelState.AddModelError("UrunYokError", "Sepetinizde ürün bulunmamaktadır.");
            }
            if (ModelState.IsValid)
            {
                SaveOrder(cart, entity);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(entity);
            }
        }
        private void SaveOrder(Cart cart,ShippingDetails entity)
        {
            var order =new  Order();
            order.OrderNumber = "A" + (new Random()).Next(11111, 99999).ToString();
            order.Total = cart.Total();
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.Waiting;
            order.Username = User.Identity.Name;

            order.AdresBasligi = entity.AdresBasligi;
            order.Adres = entity.Adres;
            order.Sehir = entity.Sehir;
            order.Semt = entity.Semt;
            order.Mahalle = entity.Mahalle;
            order.PostaKodu = entity.PostaKodu;

            order.Orderlines = new List<OrderLine>();
            foreach (var pr in cart.CartLines)
            {
                var orderline = new OrderLine();
                orderline.Quantity = pr.Quantity;
                orderline.Price = pr.Quantity * pr.Books.PresentPrice;
                orderline.BooksId = pr.Books.ID;

                order.Orderlines.Add(orderline);
            }
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }
    }
}
