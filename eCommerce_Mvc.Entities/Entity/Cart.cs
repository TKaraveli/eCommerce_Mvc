using System.Collections.Generic;
using System.Linq;

namespace eCommerce_Mvc.Entities.Entity
{
    public class Cart
    {
        //public Cart()
        //{
        //        Products = new List<Product>();
        //}

        //public int CartId { get; set; }

        //public virtual ICollection<Product> Products { get; set; }

        //public int CustomerId { get; set; }

        //public Customer Customer { get; set; }

        //public decimal TotalPrice { get; set; }

        public int CartId { get; set; }

        private List<CartLine> _cardLines = new List<CartLine>();

        public List<CartLine> CartLines
        {
            get { return _cardLines; }
        }

        public void AddProduct(Product product, int quantity)
        {
            var line = _cardLines.FirstOrDefault(i => i.Product.ProductId == product.ProductId);
            if (line == null)
            {
                _cardLines.Add(new CartLine() { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Product product)
        {
            _cardLines.RemoveAll(i => i.Product.ProductId == product.ProductId);
        }

        public double Total()
        {
            return _cardLines.Sum(i => i.Product.UnitPrice * i.Quantity);
        }

        public void Clear()
        {
            _cardLines.Clear();
        }
    }

    public class CartLine
    {
        public int CartLineId { get; set; }

        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

