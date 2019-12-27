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
            using (ProjectContext databaseContext = new ProjectContext())
            {
                //news = databaseContext.News.ToList();
                //news = databaseContext.News.Include(i => i.Category).ToList();
                products = databaseContext.Products.Include("Category").ToList();
            }

            return products;
        }
    }
}
