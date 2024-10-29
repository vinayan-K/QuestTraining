using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAssignment
{
    internal class PercentageDiscount : IDiscount
    {
        private readonly double _discountpercentage;
        public PercentageDiscount(double discountPercentage)
        {
            _discountpercentage = discountPercentage;
        }
        public double Discount(double totalPrice)
        {
            return totalPrice = totalPrice - (totalPrice * _discountpercentage / 100);
        }
    }
}
