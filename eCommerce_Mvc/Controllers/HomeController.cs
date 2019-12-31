using eCommerce_Mvc.Entities.DTO;
using eCommerce_Mvc.Entities.Entity;
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

        private readonly LoginService _loginService;

        Cart cart;

        public HomeController()
        {
            _productServices = new ProductServices();
            _loginService = new LoginService();
            cart = new Cart();
        }

        public ActionResult Index()
        {
            List<ProductDTO> productList = _productServices.GetProductDTOs();

            return View(productList);
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(string Email, string Password)
        {
            var result = _loginService.IsExistLogin(Email, Password);

            if (result == true)
            {
                Response.Write("<script>alert('Başarı İle Giriş Yaptınız!')</script>");

                return RedirectToAction("Index", "Product", new { area = "Admin" });
            }

            else
            {
                Response.Write("<script>alert('Geçersiz Kullanıcı Adı ve Parola!')</script>");

                return View();

            }

        }

        public ActionResult SignUp()
        {
            return View();

        }        

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult Menu()
        {
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return View(cart);
        }
    }
}