using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.Entities.DTO;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.Helpers.Extensions
{
    public static class ProductExtensions
    {
        public static ProductDTO GetProductDto(Product product)
        {
            ProductDTO DTOProduct = new ProductDTO
            {
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                Information = product.LongDesciription.Substring(0, 20),
                UnitPrice = product.UnitPrice,
                CategoryName =  product.Category.CategoryName
            };

            return DTOProduct;
        }

        public static List<ProductDTO> GetProductDto(this IEnumerable<Product> products)
        {
            List<ProductDTO> productList = products.Select(i => new ProductDTO
            {
                Name = i.Name,
                ImageUrl = i.ImageUrl,
                Information = i.LongDesciription.Substring(0, 20),
                UnitPrice = i.UnitPrice,
                CategoryName = i.Category.CategoryName
            }).ToList();

            return productList;
        }
    }
}
