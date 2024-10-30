using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAssignment
{
    internal class BillingService
    {
        private readonly IDiscount _discount;
        public BillingService(IDiscount discount)
        {
            _discount = discount;
        }

        public double TotalAmount(List<CartItem> cartItems)
        {
            double total = cartItems.Sum(x => x.TotalPrice);
            if (_discount != null)
            {
                total = _discount.Discount(total);
            }
            return total;
        }
    }
}
