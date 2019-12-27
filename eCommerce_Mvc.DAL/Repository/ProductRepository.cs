using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.DAL.Database;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.DAL.Repository
{
    public class ProductRepository
    {
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

            ProjectContext databaseContext = new ProjectContext();
            
                //news = databaseContext.News.ToList();
                //news = databaseContext.News.Include(i => i.Category).ToList();
                products = databaseContext.Products.Include("Category").ToList();
                products = databaseContext.Products.Include("Reviews").ToList();
                products = databaseContext.Products.Include("Supplier").ToList();
                products = databaseContext.Products.Include("Writer").ToList();            

            return products;
        }

        public Product GetProduct(int id)
        {
            Product product;
            var databaseContext = new ProjectContext();
            
                //product = databaseContext.Products.Find(id);
                product = databaseContext.Products.FirstOrDefault(i => i.ProductId.Equals(id));                
            
            return product;
        }
    }
}
