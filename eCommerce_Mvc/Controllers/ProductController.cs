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
        public ActionResult Index(int id,string Name, string Email, string Website, string Message)
        {

            var userName = Name;
            var userMail = Email;
            var userSite = Website;
            var userMessage = Message;
            var commentTime = DateTime.Now;

            ReviewServices _reviewServices = new ReviewServices();

            ProductServices _productServices = new ProductServices();

            Reviews review = new Reviews
            {
                ProductID = id,
                Name = userName,
                Email = userMail,
                Review = Message,
                ReviewDate = commentTime
            };


            _reviewServices.AddReviews(review);

            Product product = _productServices.GetProduct(id);

            return View(product);
        }
    }
}