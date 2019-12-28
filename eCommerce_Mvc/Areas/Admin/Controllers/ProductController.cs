using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce_Mvc.Areas.Admin.Models;
using eCommerce_Mvc.Entities.DTO;
using eCommerce_Mvc.Entities.Entity;
using eCommerce_Mvc.Services;

namespace eCommerce_Mvc.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductServices _productServices;

        public ProductController()
        {
            _productServices = new ProductServices();
        }

        // GET: Admin/Category
        //[HttpPatch]
        //[HttpPut]
        //[HttpDelete]
        //[HttpPost]
        //[HttpGet]

        //[AcceptVerbs("GET", "POST")]
        //[AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]

        public ActionResult Index()
        {
            CategoryServices _categoryServices = new CategoryServices();
            List<Category> categories = _categoryServices.GetCategories();

            WriterServices _writerServices = new WriterServices();
            List<Writer> writers = _writerServices.GetWriters();

            ProductServices _productServices = new ProductServices();
            List<Product> products = _productServices.GetProducts();

            SupplierServices _supplierServices = new SupplierServices();
            List<Supplier> suppliers = _supplierServices.GetSuppliers();

            var model = new AdminIndexViewModel()
            {
                Kategoriler = kategoriler,
                Yazarlar = yazarlar,
                Haberler = haberler
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = _categoryServices.GetCategory(id);

            if (category == null)
                return HttpNotFound();

            return View(category.GetCategoryDto());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CategoryDTO categoryDto)
        {
            if (id != categoryDto.Id)
                return new HttpNotFoundResult();

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Gerekli alanları doldurun!");
                return View();
            }

            var category = categoryDto.GetCategory();

            _categoryServices.EditCategory(category);

            return RedirectToAction(nameof(Index));
        }
    }
}