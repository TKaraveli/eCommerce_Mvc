using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce_Mvc.Entities.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public string ImageUrl { get; set; }

        public string Information { get; set; }

        public string CategoryName { get; set; }
    }
}
