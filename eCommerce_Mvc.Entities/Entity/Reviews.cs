using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_Mvc.Entities.Entity
{
    public class Reviews
    {
        [Key]
        public int ReviewsID { get; set; }

        //[Required, ForeignKey("Customer")]
        //public int CustomerID { get; set; }

        [Required, ForeignKey("Product")]
        public int ProductID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [Required, MaxLength(500)]
        public string Review { get; set; }

        public int? Rate { get; set; }

        public DateTime? ReviewDate { get; set; }

        public bool? IsDeleted { get; set; }

        //public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}