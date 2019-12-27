using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.Entities.DTO;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.Helpers.Extensions
{
    public static class CategoryExtensions
    {
        public static List<CategoryDTO> GetCategoryDto(this IEnumerable<Category> categories)
        {
            var categoryDto = categories.Select(category => new CategoryDTO
            {
                Id = category.CategoryId,
                Name = category.CategoryName,
                Description = category.CategoryDescription
            }).ToList();

            return categoryDto;
        }

        public static CategoryDTO GetCategoryDto(this Category category)
        {
            var categoryDto = new CategoryDTO
            {
                Id = category.CategoryId,
                Name = category.CategoryName,
                Description = category.CategoryDescription
            };

            return categoryDto;
        }

        public static Category GetCategory(this CategoryDTO categoryDto)
        {
            var category = new Category
            {
                CategoryId = categoryDto.Id,
                CategoryName = categoryDto.Name,
                CategoryDescription = categoryDto.Description
            };

            return category;
        }
    }
}
