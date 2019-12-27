using eCommerce_Mvc.Entities.DTO;
using eCommerce_Mvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductServices _productServices;

        public HomeController()
        {
            _productServices = new ProductServices();
        }

        public ActionResult Index()
        {
            List<ProductDTO> productList = _productServices.GetProductDTOs();

            return View(productList);
        }
    }
}