using System.Collections.Generic;

namespace eCommerce_Mvc.Entities.Entity
{
    public class Writer
    {
        public Writer()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
