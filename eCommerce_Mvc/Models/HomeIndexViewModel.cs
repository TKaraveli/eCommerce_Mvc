using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerce_Mvc.Entities.DTO;

namespace eCommerce_Mvc.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            Products = new List<ProductDTO>();
            Categories = new List<CategoryDTO>();
        }

        public List<ProductDTO> Products { get; set; }

        public List<CategoryDTO> Categories { get; set; }
    }
}