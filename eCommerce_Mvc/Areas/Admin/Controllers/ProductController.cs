using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce_Mvc.Areas.Admin.Models;
using eCommerce_Mvc.DAL.Database;
using eCommerce_Mvc.Entities.DTO;
using eCommerce_Mvc.Entities.Entity;
using eCommerce_Mvc.Services;

namespace eCommerce_Mvc.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductServices _productServices;

        ProjectContext _db = new ProjectContext();

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
                Categories = categories,
                Writers = writers,
                Products = products,
                Suppliers = suppliers
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string productName, string supplierName,string categoryName, double unitPrice, string writerName, string description, string productCover, int pages, int publishYear, bool isActive)
        {
            ProductServices _productServices = new ProductServices();

            Category newCategory = new Category();

            newCategory = _db.Categories.FirstOrDefault(x => x.CategoryName == categoryName);

            Supplier newsSupplier = new Supplier();

            newsSupplier = _db.Supplier.FirstOrDefault(x => x.CompanyName == supplierName);

            Writer newWriter = new Writer();

            string fullName = writerName;
            var names = fullName.Split(' ');
            string name = names[0];
            string surName = names[1];

            newWriter = _db.Writers.FirstOrDefault(x => (x.Name == name) && (x.Surname == surName));

            Product product = new Product
            {
                Name = productName,
                LongDesciription = description,
                ImageUrl = productCover,
                SupplierId = newsSupplier.SupplierId,
                CategoryId = newCategory.CategoryId,
                WriterId = newWriter.Id,
                UnitPrice = unitPrice,
                Pages = pages,
                PublishYear = publishYear

            };

            _productServices.AddProduct(product);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Delete(string product)
        {
            string selectedProduct = product;
            var names = selectedProduct.Split(' ');
            string productIdString = names[0];

            int productId = Convert.ToInt32(productIdString);

            ProductServices _productServices = new ProductServices();

            Product deletedProduct = new Product();

            deletedProduct = ProjectContext.staticContext.Products.FirstOrDefault(x => x.ProductId == productId);

            deletedProduct = ProjectContext.staticContext.Products.FirstOrDefault(x => x.ProductId == productId);

            _productServices.DeleteProduct(deletedProduct);

            return RedirectToAction("Index", "Home");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, CategoryDTO categoryDto)
        //{
        //    if (id != categoryDto.Id)
        //        return new HttpNotFoundResult();

        //    if (!ModelState.IsValid)
        //    {
        //        ModelState.AddModelError("", "Gerekli alanları doldurun!");
        //        return View();
        //    }

        //    var category = categoryDto.GetCategory();

        //    _categoryServices.EditCategory(category);

        //    return RedirectToAction(nameof(Index));
        //}
    }
}