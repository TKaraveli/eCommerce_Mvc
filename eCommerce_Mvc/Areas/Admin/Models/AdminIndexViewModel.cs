using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.Areas.Admin.Models
{
    public class AdminIndexViewModel
    {
        public List<Category> Categories { get; set; }

        public List<Writer> Writers { get; set; }

        public List<Product> Products { get; set; }

        public List<Supplier> Suppliers { get; set; }
    }
}