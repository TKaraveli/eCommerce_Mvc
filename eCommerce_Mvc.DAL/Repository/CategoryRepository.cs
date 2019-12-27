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
    public class CategoryRepository
    {
        public List<Category> GetAllCategories()
        {
            List<Category> categories;
            using (var database = new ProjectContext())
            {
                categories = database.Categories.ToList();
            }

            return categories;
        }

        public Category GetCategory(int id)
        {
            Category category;
            using (var databaseContext = new ProjectContext())
            {
                //category = databaseContext.Categories.Find(id);
                category = databaseContext.Categories.FirstOrDefault(i => i.CategoryId.Equals(id));
            }
            return category;
        }

        public bool EditCategory(Category category)
        {
            using (var databaseContext = new ProjectContext())
            {
                databaseContext.Entry(category).State = EntityState.Modified;
                return databaseContext.SaveChanges() > 0;
            }
        }
    }
}
