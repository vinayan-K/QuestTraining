using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAssignment
{
    internal class Cart
    {
        private readonly List<CartItem> _items = new List<CartItem>();
        private IDiscount _discount;

        public void AddItem(CartItem item)
        {
            _items.Add(item);
        }

        public void RemoveItem(CartItem item)
        {
            _items.Remove(item);
        }

        public void DiscountMethod(IDiscount discount)
        {
            _discount = discount;
        }

        public double TotalAmount()
        {
            double total = _items.Sum(x => x.Quantity * x.Price);
            if (_discount != null)
            {
                total = _discount.Discount(total);
            }
            return total;
        }
    }
}
