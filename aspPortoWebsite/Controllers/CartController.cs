using aspPortoWebsite.Extension;
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
        #region
        //public IActionResult Index()
        //{
        //    return View(GetCart());
        //}
        //public async Task<IActionResult> AddToCart(int id)
        //{
        //    var product = dbContext.Books.FirstOrDefault(i => i.ID == id);
        //    if (product == null)
        //    {
        //        GetCart().AddProduct(product, 1);
        //    }
        //    return RedirectToAction("Index");
        //}
        //public async Task<IActionResult> RemoveFromCart(int id)
        //{
        //    var product = dbContext.Books.FirstOrDefault(i => i.ID == id);

        //    if (product != null)
        //    {
        //        GetCart().DeleteProduct(product);
        //    }
        //    return RedirectToAction("Index");
        //}
        //public Cart GetCart()
        //{
        //    //var cart = (Cart)Session["Cart"];
        //    var cart = JsonConvert.DeserializeObject<Cart>(HttpContext.Session.GetString("Cart"));

        //    if (cart == null)
        //    {
        //        cart = new Cart();
        //        //  Session["Cart"] = cart;
        //    }
        //    return cart;
        //}
        //public PartialViewResult Summary()
        //{
        //    return PartialView(GetCart());
        //}
        //public async Task<IActionResult> Checkout(ShippingDetails entity)
        //{
        //    var cart = GetCart();
        //    if (cart._cardLines.Count==0)
        //    {
        //        ModelState.AddModelError("UrunYokError", "Sepetinizde ürün bulunmamaktadır.");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        SaveOrder(cart, entity);
        //        cart.Clear();
        //        return View("Completed");
        //    }
        //    else
        //    {
        //        return View(entity);
        //    }
        //}
        //private void SaveOrder(Cart cart,ShippingDetails entity)
        //{
        //    var order =new  Order();
        //    order.OrderNumber = "A" + (new Random()).Next(11111, 99999).ToString();
        //    order.Total = cart.Total();
        //    order.OrderDate = DateTime.Now;
        //    order.OrderState = EnumOrderState.Waiting;
        //    order.Username = User.Identity.Name;

        //    order.AdresBasligi = entity.AdresBasligi;
        //    order.Adres = entity.Adres;
        //    order.Sehir = entity.Sehir;
        //    order.Semt = entity.Semt;
        //    order.Mahalle = entity.Mahalle;
        //    order.PostaKodu = entity.PostaKodu;

        //    order.Orderlines = new List<OrderLine>();
        //    foreach (var pr in cart.CartLines)
        //    {
        //        var orderline = new OrderLine();
        //        orderline.Quantity = pr.Quantity;
        //        orderline.Price = pr.Quantity * pr.Books.PresentPrice;
        //        orderline.BooksId = pr.Books.ID;

        //        order.Orderlines.Add(orderline);
        //    }
        //    dbContext.Orders.Add(order);
        //    dbContext.SaveChanges();
        //}
        #endregion

        public async Task<IActionResult> Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            if (cart!=null)
            {
                ViewBag.total = cart.Sum(item => item.Books.PresentPrice * item.Quantity);
            }
            return View();
        }
        private int isExits(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Books.ID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        public async Task<IActionResult> Buy(int id,int? page)
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Books = dbContext.Books.Where(x => x.ID == id).FirstOrDefault(), Quantity = page??1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExits(id);
                if (index!=-1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Books = dbContext.Books.Where(x => x.ID == id).FirstOrDefault(), Quantity = page ?? 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExits(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
    }
}
