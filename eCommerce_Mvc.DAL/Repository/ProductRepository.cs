using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.DAL.Database;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.DAL.Repository
{
    public class ProductRepository
    {
        ProjectContext databaseContext = new ProjectContext();

        public List<Product> GetAllProducts()
        {
            List<Product> products;
            //using (ProjectContext databaseContext = new ProjectContext())
            //{
            //    //news = databaseContext.News.ToList();
            //    //news = databaseContext.News.Include(i => i.Category).ToList();
            //    products = databaseContext.Products.Include("Category").ToList();
            //    products = databaseContext.Products.Include("Reviews").ToList();
            //    products = databaseContext.Products.Include("Supplier").ToList();
            //    products = databaseContext.Products.Include("Writer").ToList();
            //}

            //news = databaseContext.News.ToList();
            //news = databaseContext.News.Include(i => i.Category).ToList();
            //products = databaseContext.Products.Include("Category").ToList();
            //products = databaseContext.Products.Include("Reviews").ToList();
            //products = databaseContext.Products.Include("Supplier").ToList();
            //products = databaseContext.Products.Include("Writer").ToList();            
            products = databaseContext.Products.ToList();

            return products;
        }

        public Product GetProduct(int id)
        {
            Product product = new Product();
            var databaseContext = new ProjectContext();
            
                //product = databaseContext.Products.Find(id);
                product = databaseContext.Products.FirstOrDefault(i => i.ProductId.Equals(id));                
            
            return product;
        }

        public bool AddProduct(Product product)
        {            
                databaseContext.Entry(product).State = EntityState.Added;
                return databaseContext.SaveChanges() > 0;
            
        }

        public bool DeleteProduct(Product product)
        {
                ProjectContext.staticContext.Entry(product).State = EntityState.Deleted;
                return ProjectContext.staticContext.SaveChanges() > 0;
            
        }
    }
}
