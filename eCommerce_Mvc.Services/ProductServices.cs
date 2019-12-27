using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.DAL.Repository;
using eCommerce_Mvc.Entities.DTO;
using eCommerce_Mvc.Entities.Entity;
using eCommerce_Mvc.Helpers.Extensions;

namespace eCommerce_Mvc.Services
{
    public class ProductServices
    {
        private readonly ProductRepository _productRepository;

        public ProductServices()
        {
            _productRepository = new ProductRepository();
        }

        public List<ProductDTO> GetProductDTOs()
        {
            List<Product> productList = _productRepository.GetAllProducts();
            List<ProductDTO> dtoProductList = productList.GetProductDto();

            return dtoProductList;
        }
    }
}
