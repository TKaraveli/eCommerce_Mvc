using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.DAL.Repository;
using eCommerce_Mvc.Entities.DTO;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.Services
{
    public class CategoryServices
    {
        private readonly CategoryRepository _categoryRepository;
        private static int _rowNumber;

        public CategoryServices()
        {
            _categoryRepository = new CategoryRepository();
            _rowNumber = Convert.ToInt32(ConfigurationManager.AppSettings["TopRowNumber"]);
        }

        public List<Category> GetCategories()
        {
            var categories = _categoryRepository.GetAllCategories();
            return categories;
        }


        public List<CategoryDTO> GetCategoriesDTO()
        {
            var categories = _categoryRepository.GetAllCategories();

            var categoryDto = categories.GetCategoryDto();
            
            return categoryDto;
        }

        public List<CategoryDTO> GetTopCategoriesDTO()
        {
            var categories = _categoryRepository.GetAllCategories();

            var categoryDto = categories.Take(_rowNumber).GetCategoryDto();

            return categoryDto;
        }

        public Category GetCategory(int id)
        {
            if (id < 0)
                return null;

            var result = _categoryRepository.GetCategory(id);

            return result;
        }

        public void EditCategory(Category category)
        {
            if (category == null)
                return;

            _categoryRepository.EditCategory(category);
        }
    }
}
