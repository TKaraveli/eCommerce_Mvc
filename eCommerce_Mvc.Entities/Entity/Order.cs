using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_Mvc.Entities.Entity
{
    public class Order 
    {        
        [Key]
        public int OrderId { get; set; }

        [Required, ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [Required, ForeignKey("Payment")]
        public int PaymentId { get; set; }        

        public int? Discount { get; set; }

        public int? Taxes { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippingFee { get; set; }

        public bool? IsCompleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? OrderDate { get; set; }

        public bool? Dispatched { get; set; }

        public DateTime? DispatchedDate { get; set; }

        public bool? Shipped { get; set; }

        public DateTime? ShippingDate { get; set; }

        public bool? Deliver { get; set; }

        public DateTime? DeliveryDate { get; set; }        

        public bool? CancelOrder { get; set; }       

        public virtual Customer Customer { get; set; }        

        public virtual Payment Payment { get; set; }      
       
    }
}