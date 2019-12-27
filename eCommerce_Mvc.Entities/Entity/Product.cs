using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_Mvc.Entities.Entity
{
    public class Product
    {
        public Product()
        {            
            Reviews = new HashSet<Reviews>();            
        }

        [Key]
        public int ProductId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, ForeignKey("Supplier")]
        public int SupplierId { get; set; }

        [Required, ForeignKey("Category")]
        public int CategoryId { get; set; }
        
        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }

        [Required /*Column(TypeName = "money")*/]
        public double UnitPrice { get; set; }

        public double? OldPrice { get; set; }

        //[MaxLength(20)]
        //public string UnitWeight { get; set; }

        //[MaxLength(20)]
        //public string Size { get; set; }

        public decimal? Discount { get; set; }

        public int? UnitsInStock { get; set; }

        public int WriterId { get; set; }

        public virtual Writer Writer { get; set; }

        //public int? UnitOnOrder { get; set; }

        public bool? ProductAvailable { get; set; }

        [Required,MaxLength(500)]
        public string ImageUrl { get; set; }

        //[Required, MaxLength(200)]
        //public string AltText { get; set; }

        [MaxLength(300)]
        public string ShortDesciription { get; set; }

        [MaxLength(2000)]
        public string LongDesciription { get; set; }

        [MaxLength(500)]
        public string Picture1 { get; set; }

        [MaxLength(500)]
        public string Picture2 { get; set; }

        [MaxLength(500)]
        public string Picture3 { get; set; }

        [MaxLength(500)]
        public string Picture4 { get; set; }

        [MaxLength(500)]
        public string Picture5 { get; set; }

        [MaxLength(500)]
        public string Picture6 { get; set; }

        [MaxLength(500)]
        public string Picture7 { get; set; }

        [MaxLength(500)]
        public string Picture8 { get; set; }        

        [MaxLength(250)]
        public string Notes { get; set; }

        public int Pages { get; set; }

        public int PublishYear { get; set; }

        public string Language { get; set; }

        public virtual Category Category { get; set; }

        public virtual Supplier Supplier { get; set; }              

        public virtual ICollection<Reviews> Reviews { get; set; }    



    }
    }
