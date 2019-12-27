using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_Mvc.Entities.Entity
{
    public class Payment
    {
        public Payment()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        public int PaymentId { get; set; }

        [Required/*, ForeignKey("PaymentType")*/]
        public PaymentType Type { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebitAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        public DateTime? PaymentDateTime { get; set; }

        //public virtual PaymentType PaymentType { get; set; }

        public virtual ICollection<Order> Order { get; set; }       
    }
}