using eCommerce_Mvc.DAL.Database;
using eCommerce_Mvc.Entities.Entity;
using eCommerce_Mvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce_Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductServices _productServices;

        public ProductController()
        {
            _productServices = new ProductServices();
        }

        public ActionResult Index(int id)
        {

            Product product = _productServices.GetProduct(id);

            return View(product);
        }

        [HttpPost]
        public ActionResult Index(string Name, string Email, string Website, string Message)
        {

            Product product = _productServices.GetProduct(id);

            var userName = Name;
            var userMail = Email;
            var userSite = Website;
            var userMessage = Message;
            var commentTime = DateTime.Now;

            ReviewControllerBLL reviewControllerBll = new ReviewControllerBLL();

            ProductServices _productServices = new ProductServices();

            Reviews review = new Reviews
            {
                ProductID = 8,
                Name = userName,
                Email = userMail,
                Review = Message,
                ReviewDate = commentTime
            };


            reviewControllerBll.Ekle(review);

            Product product = _productServices.GetProduct

            return View(product);
        }
    }
}