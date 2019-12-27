using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_Mvc.Entities.Entity
{
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();            
            //Reviews = new HashSet<Reviews>();
            Wishlists = new HashSet<Wishlists>();
        }

        [Key]
        public int CustomerId { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required ,MaxLength(50)]
        public string Mail { get; set; }

        [Required, MaxLength(20)]
        public string Password { get; set; }

        public int? Age { get; set; }
        public bool? Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }      

        [Required, MaxLength(50)]
        public string State { get; set; }

        [Required, MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string PostalCode { get; set; }              

        [Required, MaxLength(50)]
        public string Phone { get; set; }       
             
        [Required, MaxLength(50)]
        public string Address1 { get; set; }

        [MaxLength(50)]
        public string Address2 { get; set; }                
        
        public DateTime? LastLogin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }        

        public virtual ICollection<Order> Orders { get; set; }       

        //public virtual ICollection<Reviews> Reviews { get; set; }

        public virtual ICollection<Wishlists> Wishlists { get; set; }
    }
}