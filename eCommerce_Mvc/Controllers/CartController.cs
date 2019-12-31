using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce_Mvc.DAL.Database;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.Controllers
{
    public class CartController : Controller
    {
        private ProjectContext db = new ProjectContext();

        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }

        public ActionResult AddToCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.ProductId == Id);

            if (product != null)
            {
                GetCart().AddProduct(product, 1);
            }

            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.ProductId == Id);

            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }

            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            var cart = (Cart)Session["Cart"];

            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }

        public ActionResult Checkout()
        {
            return View(GetCart());
        }
    }
}