using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce_Mvc.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult Literature()
        {
            return View();
        }

        public ActionResult Science()
        {
            return View();

        }
    }
}