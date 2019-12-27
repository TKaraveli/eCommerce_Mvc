using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerce_Mvc.Entities.Entity
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Required, MaxLength(50)]
        public string CategoryName { get; set; }

        [MaxLength(250)]
        public string CategoryDescription { get; set; }        

        public bool? IsActive { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}