using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_Mvc.Entities.Entity
{
    public class OrderDetail
    {
        public OrderDetail()
        {            
            Product = new HashSet<Product>();
        }

        [Key]
        public int OrderDetailsId { get; set; }

        [Required, ForeignKey("Order")]
        public int OrderId { get; set; }        

        public decimal? UnitPrice { get; set; }

        public int? Quantity { get; set; }

        public decimal? Discount { get; set; }

        //public decimal? TotalAmount { get; set; }

        //public DateTime? OrderDate { get; set; }
               
        public virtual Order Order { get; set; }

        public virtual ICollection<Product> Product { get; set; }

        //public virtual ICollection<Order> Order { get; set; }
    }
}