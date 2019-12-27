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
    }
}